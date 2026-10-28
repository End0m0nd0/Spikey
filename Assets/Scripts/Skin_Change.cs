using UnityEngine;

public class Skin_Change : MonoBehaviour
{
    public SpriteRenderer SkinObject;



    void Start()
    {
        Game_Manager.selectedSkin = Game_Manager.equipedSkin;
        SkinObject.sprite = Game_Manager.instance.Skins[(int)Game_Manager.selectedSkin];
    }

    public void Next()
    {
        if (Game_Manager.selectedSkin == Game_Manager.instance.Skins.Length-1)
            Game_Manager.selectedSkin = 0;
        else Game_Manager.selectedSkin++;
        SkinChange();
    }

    public void Previous()
    {
        Game_Manager.selectedSkin--;
        if (Game_Manager.selectedSkin == -1)
            Game_Manager.selectedSkin = Game_Manager.instance.Skins.Length-1;
        SkinChange();
    }

    void SkinChange()
    {
        SkinObject.sprite = Game_Manager.instance.Skins[(int)Game_Manager.selectedSkin];
    }
}
