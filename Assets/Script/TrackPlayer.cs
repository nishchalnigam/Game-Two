using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour {

    public Transform target;
    public Vector3 offset;

    public float rotateSpeed = 1f;

    public Transform pivot;
    // Use this for initialization
    void Start () {
        offset = target.position-transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        //Get the x position of the mouse & rotate call of duty style

        //float horiz = Input.GetAxis("Mouse X") * rotateSpeed;

        //target.Rotate(0, horiz, 0);

        //float vert = Input.GetAxis("Mouse Y") * rotateSpeed;

        //target.Rotate(-vert,0, 0);
        ////rotate camera based on car rotation


        //float desiredxangle = target.eulerAngles.x;
        //float desiredyangle = target.eulerAngles.y;

        //Quaternion rotation = Quaternion.Euler(desiredxangle,desiredyangle,90);

        ////transform.position = target.position - (rotation*offset);

        ////transform.position = target.position - offset;
        //transform.LookAt(target);
    }
}
