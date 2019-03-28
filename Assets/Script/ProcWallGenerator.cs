using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcWallGenerator : MonoBehaviour {

    public GameObject wall;

    Rigidbody rb;
    private int tileToGenerate = 0;
    // Use this for initialization
    void Start () {
        for(int i =0;i<200;i++)
        {
            GameObject obj = Instantiate(wall);
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 5f);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 5f);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
