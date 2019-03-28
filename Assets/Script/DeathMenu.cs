using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour {

    public string mainLevel;
    public ScoreManager leScoreManager;

    void Start()
    {
        leScoreManager = FindObjectOfType<ScoreManager>();
    }


    public void RestartGame()
    {
        //Time.timeScale = 1f;
        Application.LoadLevel("SampleScene");
    }

    public void ResumeGame()
    {
        if(leScoreManager.Coins>20)
        { 
            Time.timeScale = 1f;
            leScoreManager.ExtraLife();
        }
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(mainLevel);
    }




}
