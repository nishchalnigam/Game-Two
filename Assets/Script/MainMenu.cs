using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string playLevel;
    //Load GameScene
    public void PlayGame()
    {

        Application.LoadLevel(playLevel);

    }

    //Quit
    public void ExitGame()
    {
        Application.Quit();
    }
}
