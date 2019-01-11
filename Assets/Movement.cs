using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        //checks whether arrow or WASD buttons are used.
        if (Input.GetKey(KeyCode.A | KeyCode.W | KeyCode.S | KeyCode.D))
        {
            WASDMovement();
        }
        ArrowMovement();
    }


    //gets input from Arrow buttons and moves sphere
    private void ArrowMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void WASDMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}


//OLD CODE for movement
/**public class Movement : MonoBehaviour {

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
            rigidbody.AddForce(Vector3.forward * Time.deltaTime);
            //rigidbody.AddRelativeForce(Vector3.forward * Time.deltaTime);
        }
    }
}
**/
