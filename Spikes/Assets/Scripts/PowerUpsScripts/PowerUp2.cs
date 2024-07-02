using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    float currentTime = 0;
    GameObject[] bird;
    void Start()
    {
        bird = GameObject.FindGameObjectsWithTag("Ball");
    }


    void Update()
    {
        if (transform.position.x == 10)
        {
            if (currentTime <= Game_Manager.powerUpDurationTime+9)
            {
                currentTime += 1 * Time.deltaTime;
                Bird_Logic.jumpForce = 1350-20*Game_Manager.lowerJumpLvl;
            }
            else if (currentTime > Game_Manager.powerUpDurationTime+9)
            {
                Bird_Logic.jumpForce = 1500;
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
