using UnityEngine;

public class Coin_Collect : MonoBehaviour
{
    float startY;
    bool goingUp;
    void Start()
    {
        startY = transform.position.y;
        goingUp = true;
    }

    private void Update()
    {
        if (goingUp == true)
        { 
            if (transform.position.y < startY + 0.3f)
                transform.position += new Vector3(0f, 1f * Time.deltaTime);
            
            else goingUp = false;
        }
        if (goingUp == false)
        {
            if (transform.position.y > startY - 0.3f)
                transform.position -= new Vector3(0f, 1f * Time.deltaTime);

            else goingUp = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
            Destroy(this);
            Bird_Logic.coin_points = 0;
            if (Game_Manager.doubleCoins == false)
                Game_Manager.coin++;
            else if (Game_Manager.doubleCoins == true)
                Game_Manager.coin += 2;
        }
    }
}
