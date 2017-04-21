using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonControl : MonoBehaviour {


	//Button that Begins the game
	public void StartGame()
	{
		SceneManager.LoadScene(0);

	}

	//Button that switches to Control Info Screen
	public void Controls()
	{
		SceneManager.LoadScene(4);

	}

	//Button that quits Game 
	public void Quit()
	{
		Application.Quit();
	}

	//Button that returns to Main Menu
	public void ReturnToMainMenu()
	{
		SceneManager.LoadScene(3);
	}
}
