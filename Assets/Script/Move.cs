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
            rb.AddTorque(new Vector3(0,-10,0) * 3);
        if (Input.GetKey(KeyCode.D))
            rb.AddTorque(new Vector3(0, 10, 0) * 3);
        if (Input.GetKey(KeyCode.W))
            rb.AddRelativeForce(Vector3.left * 20);
        if (Input.GetKey(KeyCode.S))
            rb.AddRelativeForce(Vector3.right * 5);


    }
}
