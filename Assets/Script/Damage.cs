using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour {
    public Image uiImage;
    public ScoreManager leScoreManager;
    public List<Sprite> sprites;
    public AudioSource damage;

    // Use this for initialization
    void Start () {
        damage = GameObject.Find("Collision").GetComponent<AudioSource>();
        leScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //collider.

            leScoreManager.DecHealth(1);
            damage.Play();
            if (leScoreManager.PlayerHealth>=0)
            { 
                uiImage.sprite = sprites[leScoreManager.PlayerHealth];
            }
        }
    }
    

}
