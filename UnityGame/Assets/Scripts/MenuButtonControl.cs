using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonControl : MonoBehaviour {

	public void StartGame()
	{
		//Loads Forest Scene
		SceneManager.LoadScene(1);

	}

	public void LoadIceland()
	{
		//Loads IceLand Scene
		SceneManager.LoadScene(2);

	}

	public void LoadBeachland()
	{
		//Loads Beach Scene
		SceneManager.LoadScene(3);

	}

	public void Controls()
	{
		//Loads Controls Scene
		SceneManager.LoadScene(4);

	}
		
	public void ReturnToMainMenu()
	{
		//Loads Menu Scene
		SceneManager.LoadScene(0);
	}

	//Button that quits Game 
	public void Quit()
	{

		Application.Quit();
	}
}
