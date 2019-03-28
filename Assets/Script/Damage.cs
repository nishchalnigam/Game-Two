using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour {
    public Image uiImage;
    public ScoreManager leScoreManager;
    public List<Sprite> sprites;
    public AudioSource damage;
    GameObject target;
    public Transform Player;
    public float movementSpeed = 4;
    private bool canChase = false;
    public bool CanChase
    {
        get
        {
            return canChase;
        }

        set
        {
            canChase = value;
        }
    }
    Rigidbody rb;
    // Use this for initialization
    void Start ()
    {
        //Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        damage = GameObject.Find("Collision").GetComponent<AudioSource>();
        leScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //Player.position = transform.LookAt()
        if (canChase)
        {
            Chase();
        }
    }

    void Chase()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
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

        if(collision.gameObject.name == "Plane")
        {
            canChase = true;
        }
    }
    

}
