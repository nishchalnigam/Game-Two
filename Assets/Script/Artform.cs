using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Rotate around y axis
        transform.Rotate(new Vector3(0f, 1f, 0f));
	}
}
