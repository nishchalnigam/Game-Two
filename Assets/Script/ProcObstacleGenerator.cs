using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcObstacleGenerator : MonoBehaviour {

    public GameObject obstacle;

    Rigidbody rb;
    private int tileToGenerate = 0;
    // Use this for initialization
    void Start () {
        for(int i =0;i<10;i++)
        {
            GameObject obj = Instantiate(obstacle);
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 30f);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 30f);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
