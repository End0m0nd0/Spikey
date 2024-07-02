using UnityEngine;
using UnityEngine.UI;

public class PowerUpsScene : MonoBehaviour
{

    public Text spawnChance;
    public Text durationTime;
    public Text smallerBirdLVL;
    public Text lowerJumpLVL;


    void Update()
    {
        spawnChance.text = "S p a w n  C h a n c e " + (Game_Manager.chanceToSpawnPowerUp+14).ToString() + "%";
        durationTime.text= "D u r a t i o n  T i m e " + (Game_Manager.powerUpDurationTime+9).ToString() + "s";
        smallerBirdLVL.text = "Lvl " + Game_Manager.smallerBirdLvl.ToString();
        lowerJumpLVL.text = "Lvl " + Game_Manager.lowerJumpLvl.ToString();
    }

}
