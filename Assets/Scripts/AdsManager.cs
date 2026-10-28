using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour , IUnityAdsListener
{
    string placement = "rewardedVideo";
    private float fixedDeltaTime;
    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    IEnumerator Start()
    {

        Advertisement.AddListener(this);
        Advertisement.Initialize("4125414", true);

        while (!Advertisement.IsReady(placement))
            yield return null;

        
    }

    public void WatchAdd()
    {
        Advertisement.Show(placement);
    }
 
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(showResult==ShowResult.Finished)
        {
            Bird_Logic.isAddWatched = 1;
            Time.timeScale = 1f;
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Time.timeScale = 0f;
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
    }

    public void OnUnityAdsReady(string placementId)
    {
    }
    public void OnUnityAdsDidError(string message)
    {
    }

}
