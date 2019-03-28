using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text coinText;
    public Text healthText;
    
    public GameObject deathScreen;
    public GameObject winScreen;

    private int coins = 0;
    private int playerHealth = 4;

    public int PlayerHealth
    {
        get
        {
            return playerHealth;
        }

        set
        {
            playerHealth = value;
        }
    }

    public int Coins
    {
        get
        {
            return coins;
        }

        set
        {
            coins = value;
        }
    }

    //  private int increaseScore;

    // Use this for initialization
    void Start () {
        //deathScreen = GameObject.Find("DeathMenu");//.GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {

        if (playerHealth <= 0)
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            healthText.text = "Health: GameOver";
        }
        if (coins > 30)
        {
            winScreen.SetActive(true); 
        }
    }

    //Increase health and resume
    public void ExtraLife()
    {

        if (playerHealth <= 0)
        {
            Time.timeScale = 1f;
            deathScreen.SetActive(false);
            playerHealth = 2;
            healthText.text = "Health: " + playerHealth.ToString();
            coins -= 20;
            coinText.text = "Coins: " + coins.ToString();
            Damage d = FindObjectOfType<Damage>();
            d.CanChase = false;
        }

    }
    //This will increase the score
    public void IncScore(int score)
    {
        coins += score;
        coinText.text = "Coins: " + coins.ToString();
    }

    public void DecHealth(int healthRed)
    {
        playerHealth -= healthRed;
        healthText.text = "Health: " + playerHealth.ToString();
    }

}
