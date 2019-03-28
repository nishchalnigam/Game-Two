using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ProcCoinGenerator : MonoBehaviour {

    public GameObject coin;

    Rigidbody rb;
    private int tileToGenerate = 0;
    // Use this for initialization
    void Start () {
        for(int i =0;i<100;i++)
        {
            GameObject obj = Instantiate(coin);
           
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10f);
            //Debug.Log(obj.transform.position.x.ToString());
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10f);

            
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    
}
