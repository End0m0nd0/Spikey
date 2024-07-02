using UnityEngine;
using UnityEngine.UI;

public class BgScene : MonoBehaviour
{
    public Text text;
    public GameObject TextBg;
    public static bool OwnedBg;
    public GameObject Menu;
    public GameObject BgMenu;
    public GameObject[] Bg;
    public static float selectedBg;
    void Start()
    {
        selectedBg = Game_Manager.equipedBg;  
    }

    void Update()
    {
        text.text = "B u y";
        TextBg.transform.localScale = new Vector3(60, 53, 1);
        OwnedBg = false;
        foreach (var bg in Game_Manager.UnlockedBg)
            if (bg == selectedBg)
            {
                text.text = "E q u i p";
                TextBg.transform.localScale = new Vector3(95, 55, 1);
                OwnedBg = true;
                break;
            }
        if (selectedBg == Game_Manager.equipedBg)
        {
            text.text = "E q u i p p e d";
            TextBg.transform.localScale = new Vector3(145, 60, 1);
        }
    }

    public void NextBg()
    {        
        Bg[(int)selectedBg].SetActive(false);

        selectedBg++;
        if (selectedBg == Bg.Length)
            selectedBg = 0;

        Bg[(int)selectedBg].SetActive(true);
    }

    public void PreviousBg()
    {
        Bg[(int)selectedBg].SetActive(false);

        selectedBg--;
        if (selectedBg == -1)
            selectedBg = Bg.Length-1;

        Bg[(int)selectedBg].SetActive(true);
    }

    public void Back()
    {
        Bg[(int)selectedBg].SetActive(false);
        Bg[(int)Game_Manager.equipedBg].SetActive(true);
        
        Menu.SetActive(true);
        BgMenu.SetActive(false);
    }

    public void selectedBgChange()
    {
        selectedBg = Game_Manager.equipedBg;
    }
}
