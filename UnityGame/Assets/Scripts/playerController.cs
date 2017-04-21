﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	Vector3 movement;
	Vector3 tempPos;
	private Rigidbody rb;
	private int carrotnum;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
<<<<<<< HEAD
		carrotnum = 0;
=======
		tempPos = transform.position;
>>>>>>> ed4ba59d70ccab881c26f903fbc033ed7c91d7af
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");

		//Move player around scene
		Move(moveHorizontal, moveVertical);

		Turn();
	}

	 //This section moves the Player
	void Move (float mH, float mV)
	{
		//Set movement based on axis input
		movement.Set(mH, 0f, mV);

		//Make it proportianal to speed per sec
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		rb.MovePosition (transform.position + movement);
	}

<<<<<<< HEAD
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Collect")) 
		{
			other.gameObject.SetActive (false);
			carrotnum = carrotnum + 1;
		}
	}
}
=======
	//This section turns the Player relative to the camera
	void Turn()
	{
		//WORKS
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate (Vector3.up * speed * Time.deltaTime); //Turn in the same speed as move
			rb.MovePosition (transform.position + movement);
		}

		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate (Vector3.down * speed * Time.deltaTime); //Turn in the same speed as move
			rb.MovePosition (transform.position + movement);
		}

	}
}
>>>>>>> ed4ba59d70ccab881c26f903fbc033ed7c91d7af
