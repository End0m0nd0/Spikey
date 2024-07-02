using UnityEngine;
using UnityEngine.UI;

public class Equip_Button : MonoBehaviour
{
    public Text priceText;
    public Text notEnough;
    float[] price = {0, 5 , 10 , 15  , 20, 30 , 40, 50,60,70,80,90,100,110,120,130,140,150,160,170,180,190,200,220,240,260,280,300,400,500 };
    public GameObject buyMenu;
    public GameObject Menu;

    void Update()
    {
        priceText.text = price[(int)Game_Manager.selectedSkin].ToString();
    }

    public void TryToEquip()
    {
        if(Unlock_Equip.OwnedSkin==true)
        {
            Game_Manager.equipedSkin = Game_Manager.selectedSkin;
            SaveSystem.SaveData();
        }
        if(Unlock_Equip.OwnedSkin==false)
        {
            buyMenu.SetActive(true);
            Menu.SetActive(false);
        }
    }

    public void Cancel()
    {
        notEnough.text = "";
        buyMenu.SetActive(false);
        Menu.SetActive(true) ;

    }

    public void buy()
    {
        if (Game_Manager.coin >= price[(int)Game_Manager.selectedSkin])
        {
            Game_Manager.UnlockedSkin.Add((int)Game_Manager.selectedSkin);
            Game_Manager.coin -= price[(int)Game_Manager.selectedSkin];
            Game_Manager.equipedSkin = Game_Manager.selectedSkin;
            buyMenu.SetActive(false);
            SaveSystem.SaveData();
            Cancel();
        }
        else
        {
            notEnough.text = "You don't have enough coins";
        }
    }
}
