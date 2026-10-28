using UnityEngine;
using UnityEngine.UI;

public class PowerUpUpgrade : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Upgrade;
    public Text Price;
    public Text notEnough;
    static float price;
    static float currentUpgrade;



    public void SpawnChanceUpgrade()
    {
        if (Game_Manager.powerUpMaxLvl >= Game_Manager.chanceToSpawnPowerUp)
        {
            Clicked();
            Price.text = (Game_Manager.chanceToSpawnPowerUp * 15).ToString() + " ?";
            price = Game_Manager.chanceToSpawnPowerUp * 15;
            currentUpgrade = 1;
        }
    }

    public void DurationTimeUpgrade()
    {
        if (Game_Manager.powerUpMaxLvl >= Game_Manager.powerUpDurationTime)
        {
            Clicked();
            Price.text = (Game_Manager.powerUpDurationTime * 15).ToString() + " ?";
            price = Game_Manager.powerUpDurationTime * 15;
            currentUpgrade = 2;
        }
    }

    public void SmallerBirdUpgrade()
    {
        if (Game_Manager.powerUpMaxLvl-1 >= Game_Manager.smallerBirdLvl)
        {
            Clicked();
            Price.text = (Game_Manager.smallerBirdLvl * 15).ToString() + " ?";
            price = Game_Manager.smallerBirdLvl * 15;
            currentUpgrade = 3;
        }
    }

    public void LowerJumpUpgrade()
    {
        if (Game_Manager.powerUpMaxLvl-1 >= Game_Manager.lowerJumpLvl)
        {
            Clicked();
            Price.text = (Game_Manager.lowerJumpLvl * 15).ToString() + " ?";
            price = Game_Manager.lowerJumpLvl * 15;
            currentUpgrade = 4;
        }
    }

    public void Clicked()
    {
        Upgrade.SetActive(true);
        Menu.SetActive(false);
    }

    public void Yes()
    {
        if(Game_Manager.coin>=price)
        {
           switch(currentUpgrade)
            {
                case 1:
                    Game_Manager.chanceToSpawnPowerUp++;
                    Game_Manager.coin -= price;
                    break;
                case 2:
                    Game_Manager.powerUpDurationTime++;
                    Game_Manager.coin -= price;
                    break;
                case 3:
                    Game_Manager.smallerBirdLvl++;
                    Game_Manager.coin -= price;
                    break;
                case 4:
                    Game_Manager.lowerJumpLvl++;
                    Game_Manager.coin -= price;
                    break;
            }
            SaveSystem.SaveData();
            No();
        }
        else
        {
            notEnough.text = "You don't have enough coins";
        }
    }

    public void  No()
    {
        notEnough.text = " ";
        Upgrade.SetActive(false);
        Menu.SetActive(true);
    }
}
