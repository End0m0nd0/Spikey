using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public static float MusicVolume=0.5f;
    public static float SoundEffectVolume=1f;

    public Slider MusicSlider;
    public Slider SoundEffectSlider;
    
    public static bool doubleCoins = false;
    public static float selectedSkin = 0;
    public static float equipedSkin=0;
    public static float equipedBg=0;
    public static float powerUpMaxLvl=10;
    public static float smallerBirdLvl=1;
    public static float lowerJumpLvl=1;
    public static float chanceToSpawnPowerUp= 1;
    public static float powerUpDurationTime = 1;
    public static bool canPowerUpSpawn;
    public Sprite[] Skins;
    public Sprite[] SkinsDown;
    public static bool coin_on_map;
    public static float coin;
    public static int points;
    public static Game_Manager instance;
    public static List<int> UnlockedSkin = new List<int>() { 0 };
    public static List<int> UnlockedBg = new List<int>() { 0 };
    public static bool secondLife;
    public GameObject[] Bg;

    private void Start()
    {

        canPowerUpSpawn = true;
        PlayerData data = SaveSystem.LoadData();
        coin = data.coins;
        UnlockedSkin = data.UnlockedSkins;
        UnlockedBg = data.UnlockedBg;
        equipedBg = data.equipedBg;
        equipedSkin = data.equipedSkins;
        smallerBirdLvl = data.smallerBirdLvl;
        lowerJumpLvl = data.lowerJumpLvl;
        chanceToSpawnPowerUp = data.chanceToSpawnPowerUp;
        powerUpDurationTime = data.powerUpDurationTime;
        selectedSkin = data.selectedSkin;
        doubleCoins = data.doubleCoins;
        SoundEffectVolume = data.SoundEffectVolume;
        MusicVolume = data.MusicVolume;

        if (smallerBirdLvl == 0) smallerBirdLvl = 1;
        if (lowerJumpLvl == 0) lowerJumpLvl = 1;
        if (chanceToSpawnPowerUp == 0) chanceToSpawnPowerUp = 1;
        if (powerUpDurationTime == 0) powerUpDurationTime = 1;
        if (UnlockedBg == null) UnlockedBg.Add(0);
        SaveSystem.SaveData();

        foreach (var bg in Bg)
        {
            bg.SetActive(false);
        }

        Bg[(int)Game_Manager.equipedBg].SetActive(true);

        GameObject MusicObj = GameObject.FindGameObjectWithTag("Melody");
        AudioSource Melody = MusicObj.GetComponent<AudioSource>();
        Melody.volume = MusicVolume;
        MusicSlider.value = MusicVolume;
        SoundEffectSlider.value = SoundEffectVolume;
    }

    void Awake()
    {
        instance = this;
    }

    private void OnApplicationQuit()
    {
        SaveSystem.SaveData();
    }
}
