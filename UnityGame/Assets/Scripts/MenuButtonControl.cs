using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonControl : MonoBehaviour {

	//public string levelToLoad;

	public void StartGame()
	{
		SceneManager.LoadScene(0);
		//Application.LoadLevel(0);

	}

	public void Controls()
	{
		SceneManager.LoadScene(4);
		//Application.LoadLevel(4);

	}

	public void Quit()
	{
		Application.Quit();
		//SceneManager.Quit();
	}
}
