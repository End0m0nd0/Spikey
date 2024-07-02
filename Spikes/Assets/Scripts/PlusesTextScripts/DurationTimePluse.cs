using UnityEngine;
using UnityEngine.UI;

public class DurationTimePluse : MonoBehaviour
{
    Text plus;

    void Start()
    {
        plus = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if (Game_Manager.powerUpDurationTime == Game_Manager.powerUpMaxLvl + 1)
        {
            plus.text = "(Max)";
            plus.fontSize = 45;
        }
    }
}
