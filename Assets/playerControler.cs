using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    public float zSpeed;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) { 
            transform.Translate(0, 0, zSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -zSpeed);
        }
        //if (Input.GetKey(KeyCode.A))
       // {
            //transform.position += new Vector3(-zSpeed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
            //transform.position += new Vector3(zSpeed, 0, 0);
        //}
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        }
    }
}
