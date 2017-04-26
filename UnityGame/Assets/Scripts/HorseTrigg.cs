using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HorseTrigg : MonoBehaviour {

	//public Vector3 pos1;
	//public Vector3 pos2;

	private int carrotnum;
	//private int num;
	public string levelToLoad;

	//Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		/*if (carrotnum >= 5) {
			if (Input.GetKey ("c")) 
			{
				SceneManager.LoadScene (levelToLoad);
			}
		}*/
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			if (other.gameObject.CompareTag ("Collect")) {
				//Add one to counter 
				carrotnum = carrotnum + 1;

			}
			if (carrotnum >= 5) {
				SceneManager.LoadScene (levelToLoad);
			}
			
		}
	}
}


/*
	// Use this for initialization
	void Start () 
	{
		int pos1 = (gameObject.);
		int pos2 = ();
		//transform.position = positions [pos];

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Collect")) 
		{
			//Add one to counter
			carrotnum = carrotnum + 1;
		}

		if (other.gameObject.CompareTag ("Horse")) 
		{
			num = RangeInt (0, 1);

			if (num == 0) 
			{
				transform.position = positions [pos1];
			}
			if (num == 1) 
			{
				transform.position = positions [pos2];
			}
			if (carrotnum >= 5) 
			{
				num = 1;
			}
		}
	}
}
*/
