using UnityEngine;
using UnityEngine.UI;

public class SmallerBirdPluse : MonoBehaviour
{
    Text plus;

    void Start()
    {
        plus = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if (Game_Manager.smallerBirdLvl == Game_Manager.powerUpMaxLvl)
        {
            plus.text = "(Max)";
            plus.fontSize = 45;
        }
    }
}
