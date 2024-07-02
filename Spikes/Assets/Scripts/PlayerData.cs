using System.Collections.Generic;

[System.Serializable]
public class PlayerData
{
    public float MusicVolume;
    public float SoundEffectVolume;
    public bool doubleCoins;
    public float selectedSkin;
    public float smallerBirdLvl;
    public float lowerJumpLvl;
    public float chanceToSpawnPowerUp;
    public float powerUpDurationTime;
    public float equipedSkins;
    public float coins;
    public float equipedBg;
    public List<int> UnlockedBg = new List<int>();
    public List<int> UnlockedSkins = new List<int>();
    public PlayerData()
    {
        MusicVolume = Game_Manager.MusicVolume;
        SoundEffectVolume = Game_Manager.SoundEffectVolume;
        equipedBg = Game_Manager.equipedBg;
        UnlockedBg = Game_Manager.UnlockedBg;
        coins = Game_Manager.coin;
        UnlockedSkins = Game_Manager.UnlockedSkin;
        equipedSkins = Game_Manager.equipedSkin;
        smallerBirdLvl = Game_Manager.smallerBirdLvl;
        lowerJumpLvl = Game_Manager.lowerJumpLvl;
        chanceToSpawnPowerUp = Game_Manager.chanceToSpawnPowerUp;
        powerUpDurationTime = Game_Manager.powerUpDurationTime;
        doubleCoins = Game_Manager.doubleCoins;
    }
}
