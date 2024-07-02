using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{

    public void MusicChange(float newVolume)
    {
        Game_Manager.MusicVolume = newVolume;

        GameObject MusicObj = GameObject.FindGameObjectWithTag("Melody");
        AudioSource Melody = MusicObj.GetComponent<AudioSource>();
        Melody.volume = newVolume;
        SaveSystem.SaveData();
    }

    public void SoundEffectChange(float newVolume)
    {
       Game_Manager.SoundEffectVolume = newVolume;
       SaveSystem.SaveData();
    }
}
