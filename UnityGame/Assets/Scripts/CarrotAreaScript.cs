using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotAreaScript : MonoBehaviour {

	public Vector3[] positions;

	// Use this for initialization
	void Start () 
	{
		int randomNum = Random.Range (0, positions.Length);
		transform.position = positions [randomNum];
		
	}

}
