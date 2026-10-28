using UnityEngine;
using UnityEngine.Purchasing;

public class IAPstore : MonoBehaviour
{
    private string double_coins = "double_coins";
    private string coins100 = "coins100";
    private string coins500 = "coins500";
    private string max_power_ups = "max_power_ups";


    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == double_coins) Game_Manager.doubleCoins = true;
        if (product.definition.id == coins100) Game_Manager.coin += 100;
        if (product.definition.id == coins500) Game_Manager.coin += 500;
        if (product.definition.id == max_power_ups)
        {
            Game_Manager.powerUpDurationTime = Game_Manager.powerUpMaxLvl+1;
            Game_Manager.chanceToSpawnPowerUp = Game_Manager.powerUpMaxLvl+1;
            Game_Manager.lowerJumpLvl = Game_Manager.powerUpMaxLvl;
            Game_Manager.smallerBirdLvl = Game_Manager.powerUpMaxLvl;
        }

        SaveSystem.SaveData();
    }


    public void OnPurchaseFailed(Product products, PurchaseFailureReason reason)
    {

    }

}
