using UnityEngine;
public class PowerUp3 : MonoBehaviour
{
    float currentTime = 0;
    GameObject[] bird;
    public GameObject shield;

    private void Start()
    {
        bird = GameObject.FindGameObjectsWithTag("Ball");
    }

    private void Update()
    {
        if (transform.position.x == 10)
        {
            if (currentTime <= Game_Manager.powerUpDurationTime+9)
            {
                currentTime += 1 * Time.deltaTime;
            }
            else if(currentTime > Game_Manager.powerUpDurationTime+9)
            {
                Game_Manager.canPowerUpSpawn = true; 
                Game_Manager.secondLife = false;
                GameObject[] Shield = GameObject.FindGameObjectsWithTag("Shield");
                foreach (GameObject shield in Shield)
                    GameObject.Destroy(shield);
                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(shield, new Vector3(0, 0, 0), Quaternion.identity);
        transform.position = new Vector3(10, 10, 10);
        Game_Manager.secondLife = true;
    }
}
