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
		Move(moveHorizontal, moveVertical);
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//rb.AddForce (movement * speed);
	}

	void Move (float mH, float mV)
	{
		//Set movement based on axis input
		movement.Set(mH, 0f, mV);

		//Make it proportianal to speed per sec
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		rb.MovePosition (transform.position + movement);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Collect")) 
		{
			other.gameObject.SetActive (false);
		}
	}
}