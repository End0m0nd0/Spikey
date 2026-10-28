using UnityEngine;
using UnityEngine.UI;

public class Bg_EquipButton : MonoBehaviour
{
    public Text priceText;
    public Text notEnough;
    float[] price = { 0, 150, 150 ,150,150  };
    public GameObject buyMenu;
    public GameObject Menu;

    private void Update()
    {
        priceText.text = price[(int)BgScene.selectedBg].ToString();
    }

    public void TryToEquip()
    {
        if (BgScene.OwnedBg == true)
        {
            Game_Manager.equipedBg = BgScene.selectedBg;
            SaveSystem.SaveData();
        }
        if (BgScene.OwnedBg == false)
        {
            buyMenu.SetActive(true);
            Menu.SetActive(false);
        }
    }
    public void Cancel()
    {   
        notEnough.text = "";
        buyMenu.SetActive(false);
        Menu.SetActive(true);
    }

    public void buy()
    {
        if (Game_Manager.coin >= price[(int)BgScene.selectedBg])
        {
            Game_Manager.UnlockedBg.Add((int)BgScene.selectedBg);
            Game_Manager.coin -= price[(int)BgScene.selectedBg];
            Game_Manager.equipedBg = BgScene.selectedBg;
            SaveSystem.SaveData();
            Cancel();
        }
        else
        {
            notEnough.text = "You don't have enough coins";
        }
    }
}
