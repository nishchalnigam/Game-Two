using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    private Rigidbody rb;
    public int jumpScaler;
    private bool isGrounded = true;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpScaler);//Object Up
            //rb.AddForce(Vector3.up);//World Up
            isGrounded = false;
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
