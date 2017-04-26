using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))] //Only will work with character controller

public class playerController : MonoBehaviour {

	//Character Control
	public float moveSpeed;
	public float rotationSpeed;
	private CharacterController cc;

	//Level load
	public string levelToLoad;

	//In game Text
	private int carrotnum;
	public Text countText;
	public Text allText;

	//Triggers for Glinda Text
	public static bool finished = false;

	void Start ()
	{
		cc = GetComponent<CharacterController> ();

		//Carrot collection and counter code
		carrotnum = 0;
		SetCountText ();
		allText.text = "Collect all carrots to get horse";

	}

	void FixedUpdate ()
	{
		//Move Horse Player around map
		horseController();
	}

	 //This section moves the Player
	void horseController()
	{
		//Firstly turn player around the Horizontal
		cc.SimpleMove (Physics.gravity);
		transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal") * rotationSpeed *Time.deltaTime,0) );

		// Next get it to move forward on the vertical
		Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) *moveSpeed; // Vector(0,0,1)
		cc.Move(forward* Time.deltaTime);
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

		if (other.gameObject.CompareTag ("Horse")) 
		{
			if (carrotnum >= 5) 
			{
				SceneManager.LoadScene (levelToLoad);

				//Next set of text for glinda is now set
				//finished = true;
				other.gameObject.SetActive (false);
			}
		}
	}
		

	//For carrot text to show how many carrots have been collected
	//To show all carrots collected message too
	void SetCountText()
	{
		countText.text = "Carrots: " + carrotnum.ToString () + " / 5";
		//When all carrots collected new message appears and old disappears
		if (carrotnum >= 5) 
		{
			allText.text = "Collect Horse";
			countText.text = "";
		}

	}

}
