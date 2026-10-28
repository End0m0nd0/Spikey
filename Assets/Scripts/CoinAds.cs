using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class CoinAds : MonoBehaviour, IUnityAdsListener
{
    string placement = "rewardedVideo";
    public GameObject AdButton;


    IEnumerator Start()
    {

        Advertisement.AddListener(this);
        Advertisement.Initialize("4125414", true);

        while (!Advertisement.IsReady(placement))
            yield return null;


    }

  /*  public void Update()
    {
        if (Advertisement.IsReady())
        {
            AdButton.SetActive(true);
        }
        else AdButton.SetActive(false);
    }
  */

    public void WatchAdd()
    {
        Advertisement.Show(placement);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            Game_Manager.coin += 10;
            SaveSystem.SaveData();
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsReady(string placementId)
    {
    }
    public void OnUnityAdsDidError(string message)
    {
    }

}
