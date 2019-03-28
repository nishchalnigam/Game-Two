using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    //Camera for RayCasting
    public Camera raycastcam;

	// Use this for initialization
	void Start () {

        raycastcam.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        DetectPlayer();
    }

    //RayCast to dectect player
    void DetectPlayer()
    {
        RaycastHit hit;

        if(Physics.Raycast(raycastcam.transform.position,raycastcam.transform.forward,out hit))
        {
            //Debug.Log(hit.transform.name);

            if (hit.transform.name.Equals("Player"))
            {
                transform.Rotate(new Vector3(0,0,12f));
            }
        }

    }
}
