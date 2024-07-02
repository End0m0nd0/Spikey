using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyScript : MonoBehaviour
{
    private void Awake()
    {
        // DontDestroyOnLoad(transform.gameObject);

        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Melody");
        if (musicObj.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
