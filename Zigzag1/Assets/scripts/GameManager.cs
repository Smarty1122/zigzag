using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;


    void Awake()
    {
        if(instance==null)
        {
            instance = this;  
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        UImanager.instance.Gamestart();
        ScoreManager.instance.Startscore();

        GameObject.Find("platformspawner").GetComponent<platformspawner>().StartPlatformSpawning();
    }

    public void GameOver()
    {
        UImanager.instance.GameOver();
        ScoreManager.instance.Stopscore();
        gameOver = true;
    }
}
