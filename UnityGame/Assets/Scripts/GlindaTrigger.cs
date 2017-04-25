﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlindaTrigger : MonoBehaviour {

	public string GlindaToLoad;
	public bool finished;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		
		if (other.tag == "Player" ) //&& finished == true
		{
			//Load Glindas first scene
			SceneManager.LoadScene(GlindaToLoad);
		}
	}
}
