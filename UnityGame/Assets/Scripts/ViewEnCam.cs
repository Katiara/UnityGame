using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEnCam : MonoBehaviour {

	public GameObject player;
	public float Hspeed = 2.0f;
	public float Vspeed = 2.0f;

	//store as private so you can accumulate values easier
	private float vert = 0.0f; //Verticle value
	private float horiz = 0.0f; //Horizontal value
	private Vector3 offset;

	void Start ()
	{
		//This places the camera at a certain distance to the player
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = player.transform.position + offset ; //

		//Use +=  ,  -= to accumulate on each update
		vert += Hspeed * Input.GetAxis("Mouse X");
		horiz -= Vspeed * Input.GetAxis("Mouse Y");


		//Then use EulerAngles to overwrite each rotation value on update
		transform.eulerAngles = new Vector3(horiz, vert, 0.0f);
	}
}
