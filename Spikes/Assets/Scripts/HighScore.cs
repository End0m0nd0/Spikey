using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text HighScor;
    void Start()
    {
        HighScor = gameObject.GetComponent<Text>();
        HighScor.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

}
