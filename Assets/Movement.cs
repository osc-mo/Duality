using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Rigidbody rigidbody;


	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {


        RespondToMoveInput();
	}

    private void RespondToMoveInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddRelativeForce(Vector3.forward * Time.deltaTime);
        }
    }
}
