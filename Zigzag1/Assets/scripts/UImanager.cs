using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public static UImanager instance;

    public GameObject ZigzagPanel;
    public GameObject GameOverPanel;
    public GameObject Taptext;
    public Text score;
    public Text Highscore;
    public Text Bestscore;

    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Highscore.text ="Highscore : " + PlayerPrefs.GetInt("highscore").ToString();
    }

    public void Gamestart()
    {
        Highscore.text = PlayerPrefs.GetInt("highscore").ToString();
        Taptext.SetActive(false);
        ZigzagPanel.GetComponent<Animator>().Play("Panel");
    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        Bestscore.text = PlayerPrefs.GetInt("highscore").ToString();
        GameOverPanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
