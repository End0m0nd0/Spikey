using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    
    void Update()
    {
        scoreText = gameObject.GetComponent<Text>();
        scoreText.text = Game_Manager.points.ToString();
    }
}
