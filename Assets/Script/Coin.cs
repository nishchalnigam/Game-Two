using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public ScoreManager leScoreManager;
    public AudioSource coinSound;
    // Use this for initialization
    void Start () {
        leScoreManager = FindObjectOfType<ScoreManager>();
        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(0, 10, 0) * 2);
    }

    //Collect Coin and Deactivate
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.name == "Player")
        {
            leScoreManager.IncScore(1);//Increase Score by 1
            coinSound.Play();
            gameObject.SetActive(false);//Coin Dissapears
        }
    }
}
