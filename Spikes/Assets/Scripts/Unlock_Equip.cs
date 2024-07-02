using UnityEngine;
using UnityEngine.UI;

public class Unlock_Equip : MonoBehaviour
{
    public Text text;
    public GameObject TextBg;
    public static bool OwnedSkin;

    void Update()
    {
        text.text = "B u y";
        TextBg.transform.localScale = new Vector3(60, 53, 1);
        OwnedSkin = false;
        foreach (var skins in Game_Manager.UnlockedSkin)
            if (skins == Game_Manager.selectedSkin)
            {
                text.text = "E q u i p";
                TextBg.transform.localScale = new Vector3(95, 55, 1);
                OwnedSkin = true;
                break;
            }
        if (Game_Manager.selectedSkin == Game_Manager.equipedSkin)
        {
            text.text = "E q u i p p e d";
            TextBg.transform.localScale = new Vector3(145, 60, 1);
        }
    }
}
