using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird_Logic : MonoBehaviour
{
    public AudioSource Lose;
    public AudioSource Jump;
    public AudioSource CoinCollect;
    public AudioSource WallHit;
    
    
    public static float isAddWatched; 
    public static float isGameActive;
    public GameObject[] Bg;
    public GameObject loseScreen;
    public static bool goingRight;
    static public float x ;
    public static Rigidbody2D Body;
    public GameObject Spike_prefab;
    public GameObject Coin_prefab;
    SpriteRenderer Bird;
    static public float coin_points;
    public static float jumpForce = 1500f;
    private int min, max;
    public static Bird_Logic instance;
    public GameObject[] powerUps = new GameObject[3];

    void Awake()
    {
        instance = this;
    //    QualitySettings.vSyncCount = 0;
    //    Application.targetFrameRate = 240;
    }
    void Start()
    {
        Lose.volume = Game_Manager.SoundEffectVolume;
        Jump.volume = Game_Manager.SoundEffectVolume;
        CoinCollect.volume = Game_Manager.SoundEffectVolume;
        WallHit.volume = Game_Manager.SoundEffectVolume;

        isAddWatched = 0;
        isGameActive = 1;
        
        foreach(var bg in Bg)
        {
            bg.SetActive(false);
        }

        Bg[(int)Game_Manager.equipedBg].SetActive(true);
        
        Game_Manager.secondLife = false;
        jumpForce = 1500;
        goingRight = true;
        x = 5;
        Bird = gameObject.GetComponent<SpriteRenderer>();
        Bird.sprite = Game_Manager.instance.Skins[(int)Game_Manager.equipedSkin];
        Body = gameObject.GetComponent<Rigidbody2D>();
        //Instantiate(Coin_prefab, new Vector3(Random.Range(-7, 6) + 0.5f, Random.Range(-4, 3) + 0.5f, 0f), Quaternion.identity);
        Game_Manager.coin_on_map = false;
        coin_points = 0;
        Body = gameObject.GetComponent<Rigidbody2D>();
        Game_Manager.points = 0;
        min = 1;
        max = 1;
    }

    void Update()
    {
        if (isGameActive == 0)
            GameOver();
       
        
        if (Body.velocity.y >= 0) Bird.sprite = Game_Manager.instance.Skins[(int)Game_Manager.equipedSkin];
        else Bird.sprite = Game_Manager.instance.SkinsDown[(int)Game_Manager.equipedSkin];
        transform.position += new Vector3(x*Time.deltaTime, 0f, 0f);
        if (Input.GetMouseButtonDown(0))
        {
            Jump.Play();
            Body.velocity = new Vector2(0, 0);
            Body.AddForce(transform.up * jumpForce);
        }
        if (coin_points > 2)
        {
            if (!Game_Manager.coin_on_map)
            {
                Instantiate(Coin_prefab, new Vector3(Random.Range(-7, 6) + 0.5f, Random.Range(-4, 3) + 0.5f, 0f), Quaternion.identity);
                coin_points = 0;
                Game_Manager.coin_on_map = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Wall"))
        {
            WallHit.Play();
            
            if (transform.localScale.x > 0)
            {
                transform.localScale = new Vector3(-0.9f, 0.9f, 0.9f);
                goingRight = false;
            }
            else
            {
                transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                goingRight = true;
            }
            //    else transform.rotation = Quaternion.AngleAxis(180f, Vector3.up);
            switch (Game_Manager.points)
            {
                case 1:
                    min = 2;
                    max = 2;
                    break;
                case 3:
                    max = 3;
                    break;
                case 5:
                    min = 3;
                    max = 4;
                    break;
                case 8:
                    max = 5;
                    break;
            }
            if (!Game_Manager.coin_on_map) coin_points++;
            DestroyClones();
            if (x > 0)
            {
                x = -(x + 0.15f);
                float random = Random.Range(min, max);
                for (int i = 0; i < random; i++)
                    Instantiate(Spike_prefab, new Vector3(-9f, Random.Range(-4, 3) + 0.5f, 0), Quaternion.AngleAxis(270f, Vector3.forward));
            }
            else
            {
                x = -(x - 0.15f);
                float random = Random.Range(min, max);
                for (int i = 0; i < random; i++)
                    Instantiate(Spike_prefab, new Vector3(9f, Random.Range(-4, 3) + 0.5f, 0), Quaternion.AngleAxis(90f, Vector3.forward));
            }
            Game_Manager.points++;

            if (Game_Manager.canPowerUpSpawn == true)
            {
                if (Random.Range(1, 100) <= Game_Manager.chanceToSpawnPowerUp + 14)
                {
                    Game_Manager.canPowerUpSpawn = false;
                    int y = Random.Range(0, powerUps.Length);

                    Instantiate(powerUps[y], new Vector3(Random.Range(-7, 6) + 0.5f, Random.Range(-4, 3) + 0.5f, 0f), Quaternion.identity);
                }
            }
        }
        else if (other.CompareTag("Coin"))
        {
            Game_Manager.coin_on_map = false;
            CoinCollect.Play();
        }

        if (other.CompareTag("Spike") || other.CompareTag("Clone"))
        {
            if (Game_Manager.secondLife)
            {
                Game_Manager.canPowerUpSpawn = true;
                GameObject[] Shield = GameObject.FindGameObjectsWithTag("Shield");
                foreach (GameObject enemy in Shield)
                    GameObject.Destroy(enemy);
                Body.transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y);
                x = -x;
                Game_Manager.secondLife = false;
            }
            else
            {
                Lose.Play();
                loseScreen.SetActive(true);
            }
        }
    }
    public void GameOver()
    {
        if (Game_Manager.points > PlayerPrefs.GetFloat("HighScore", 0))
        PlayerPrefs.SetFloat("HighScore", Game_Manager.points);
        jumpForce = 1500;
        Game_Manager.canPowerUpSpawn = true;
        SaveSystem.SaveData();
        SceneManager.LoadScene("Game_Menu");
        Main_Menu.gameOver = true;
    }
    void DestroyClones()
    {

        GameObject[] Clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach (GameObject enemy in Clones)
            GameObject.Destroy(enemy);
    }

}
