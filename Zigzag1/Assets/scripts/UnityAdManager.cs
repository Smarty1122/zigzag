using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;


public class UnityAdManager : MonoBehaviour, IUnityAdsListener
{
    public static UnityAdManager instance;

    string GameId = "4422173";


    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
       
    }


    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GameId);
        Advertisement.AddListener(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {

            Advertisement.Show("Interstitial_Android");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string placementId)
    {
       
       //throw new System.NotImplementedException();
        UImanager.instance.Reset();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        
        if(showResult == ShowResult.Finished)
        {
            UImanager.instance.Reset();
        }

        else if (showResult == ShowResult.Skipped)
        {
            UImanager.instance.Reset();
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.Log("failed");
            UImanager.instance.Reset();
        }

    }
}
