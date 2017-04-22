using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	public float speed;
	Vector3 movement;
	Vector3 tempPos;
	private Rigidbody rb;
	private int carrotnum;
	public Text countText;
	public Text winText;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		//Carrot collection and counter code
		carrotnum = 0;
		SetCountText ();
		winText.text = "";
			
		tempPos = transform.position;
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

	//When player hits carrot, carrot will disappear
	//Carrot counter will be increased
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Collect")) 
		{
			//Deactivate the carrot so you cannot collect the same carrot twice
			other.gameObject.SetActive (false);
			//Add one to counter and set counter text
			carrotnum = carrotnum + 1;
			SetCountText ();
		}
	}

	//For carrot text to show how many carrots have been collected
	//To show all carrots collected message too
	void SetCountText()
	{
		countText.text = "Carrots:" + carrotnum.ToString ();
		//When all carrots collected new message appears and old disappears
		if (carrotnum >= 5) 
		{
			winText.text = "All carrots collected";
			countText.text = "";
		}
	}


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
