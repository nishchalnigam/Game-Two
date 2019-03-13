using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(new Vector3(-10,0,0));
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * 10);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * 10);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * 10);
    }
}
