using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Coin : MonoBehaviour {

    public ScoreManager leScoreManager;
    public AudioSource coinSound;
    // Use this for initialization
    void Start () {
        leScoreManager = FindObjectOfType<ScoreManager>();
        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
        transform.position = new Vector3(transform.position.x + GetRandomNumber(0f, 4f), transform.position.y, transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(0, 10, 0) * 2);
        //transform.position = new Vector3(GetRandomNumber(-4.6f, 4f),transform.position.y, transform.position.z);
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

    public float GetRandomNumber(float minimum, float maximum)
    {
        Random random = new Random();
        return (float)random.NextDouble() * (maximum - minimum) + minimum;
    }
}
