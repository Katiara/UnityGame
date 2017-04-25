using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotJump : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (5, 0, 45) * Time.deltaTime);

	}

}
