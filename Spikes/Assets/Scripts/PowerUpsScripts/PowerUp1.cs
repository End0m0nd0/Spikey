using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    float currentTime=0;
    GameObject[] bird;
    float y;

    private void Start()
    {
        y = 0.9f;
        bird = GameObject.FindGameObjectsWithTag("Ball");
    }
    void Update()
    {
        if (transform.position.x == 10)
        {           
            if (y >= 0.7f-Game_Manager.smallerBirdLvl/50f) y -= 0.0045f;
            if (currentTime <= Game_Manager.powerUpDurationTime+9)
                {
                currentTime += 1 * Time.deltaTime;
                if (currentTime > Game_Manager.powerUpDurationTime + 8) if (y <= 0.9f) y += 0.009f;
                if (Bird_Logic.goingRight == true)
                    {
                    bird[0].transform.localScale = new Vector3(y, y, y);
                    }
                else if (Bird_Logic.goingRight == false)
                    {
                    bird[0].transform.localScale = new Vector3(-y, y, y);
                    }
                }
            else if (currentTime > Game_Manager.powerUpDurationTime+9)
                {
                if(bird[0].transform.localScale.x>0) bird[0].transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                else bird[0].transform.localScale = new Vector3(-0.9f, 0.9f, 0.9f);
                Game_Manager.canPowerUpSpawn = true;
                Destroy(this.gameObject);
                }
            }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        transform.position = new Vector3(10, 10, 10);
        
    }
}
