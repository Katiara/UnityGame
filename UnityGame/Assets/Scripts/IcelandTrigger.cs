using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IcelandTrigger : MonoBehaviour {

	public string levelToLoad;
	public bool finished = false;

	//Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			finished = true;
			SceneManager.LoadScene(levelToLoad);
		}
	}
}
