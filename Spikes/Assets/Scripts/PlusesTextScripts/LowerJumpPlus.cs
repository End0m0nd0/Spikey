using UnityEngine;
using UnityEngine.UI;

public class LowerJumpPlus : MonoBehaviour
{
    Text plus;

    void Start()
    {
        plus = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if (Game_Manager.lowerJumpLvl == Game_Manager.powerUpMaxLvl)
        {
            plus.text = "(Max)";
            plus.fontSize = 45;
        }
    }
}

