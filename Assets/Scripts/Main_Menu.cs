using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SkinScene;
    public GameObject BgScene;
    public GameObject PowerUpScene;
    public GameObject StoreMenu;
    public GameObject BgBird;
    public GameObject GameOver;

    public static bool gameOver = false;

    void Awake()
    {
         Application.targetFrameRate = 60;
    }


    private void Start()
    {
        if (gameOver == true)
        {
            MainMenu.SetActive(false);
            GameOver.SetActive(true);
        }
        gameOver = false;
    }


    public void PlayGame()
    {
        SceneManager.LoadScene("Game_Scene");
    }

    public void BgBirdButton()
    {
        BgBird.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void BackButton()
    {
        BgBird.SetActive(false);
        BgScene.SetActive(false);
        SkinScene.SetActive(false);
        PowerUpScene.SetActive(false);
        StoreMenu.SetActive(false);
        GameOver.SetActive(false);
        MainMenu.SetActive(true);

        SaveSystem.SaveData();
    }

    public void powerUpsMenu()
    {
        PowerUpScene.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Store()
    {
        StoreMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void BirdSkin()
    {
        SkinScene.SetActive(true);
        BgBird.SetActive(false);
    }

    public void BgSkin()
    {
        BgScene.SetActive(true);
        BgBird.SetActive(false);
    }

}
