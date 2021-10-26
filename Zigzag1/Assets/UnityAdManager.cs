using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;


public class UnityAdManager : MonoBehaviour
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
}
