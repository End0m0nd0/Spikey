using UnityEngine;
using UnityEngine.UI;

public class LoseScreenTimer : MonoBehaviour
{
    Text timerText;
    float timer=10;
    public GameObject loseScreen;
    GameObject[] bird;
    public GameObject loseScreen2;
    public GameObject Score;
    public GameObject ScoreBg;

    void Start()
    {

        loseScreen2.SetActive(true);
        bird = GameObject.FindGameObjectsWithTag("Ball");
        timerText = gameObject.GetComponent<Text>();
        timer = 3;
        Score.SetActive(false);
        ScoreBg.SetActive(false);
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if(timer>0)
            timerText.text = "1";
        if (timer > 1)
            timerText.text = "2";
        if (timer > 2)
            timerText.text = "3";
        bird[0].transform.position = new Vector3(0, 2, 0);
        if (timer<0)
        {
            loseScreen2.SetActive(false);
            Score.SetActive(true);
            ScoreBg.SetActive(true);
            
            if(Bird_Logic.isAddWatched==0) Bird_Logic.isGameActive = 0;
            if(Bird_Logic.isAddWatched==1)
            {
                loseScreen.SetActive(false);
                Bird_Logic.Body.velocity = new Vector2(0, 0);
                Bird_Logic.isAddWatched = 0;
            }                
        }
    }

    public void Cancel()
    {
        timer = 0;
    }    
}
