using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	Vector3 movement;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");

		//Move player around scene
		//Move(moveHorizontal, moveVertical);

		Turn();
	}
	 //This section moves the Player
	/*void Move (float mH, float mV)
	{
		//Set movement based on axis input
		movement.Set(mH, 0f, mV);

		//Make it proportianal to speed per sec
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		rb.MovePosition (transform.position + movement);
	}*/

	//This section turns the Player relative to the camera
	//To do this we need to get the CAMERA Rotaion Y value and change the Rotation of the player to that
	void Turn()
	{
		float move = 1;
		if(Input.GetKey(KeyCode.W))
		{
		
			movement.Set (0, 0, 0);
			rb.MovePosition (transform.position + movement);

			if (move > 0 && move < 170)
			{
				transform.Rotate (0, move, 0); //Vector3.right * Time.deltaTime
				move++;
			} 
			else 
			{
				move = 1;
			}
		}

	}
}
