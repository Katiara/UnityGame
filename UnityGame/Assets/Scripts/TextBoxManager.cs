using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject texBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine; // knowing where line Starts
	public int endAtLine; // knowing where line ends

	//public playerController Player;

	void Start()
	{
		//Player = findObjectOfType<playerController> ();

		//Check if text file is there
		if (textFile != null)
		{
			textLines = (textFile.text.Split ('\n'));

		}

		if (endAtLine == 0) 
		{
			endAtLine = textLines.Length - 1;
		}
	}

	void Update()
	{
		theText.text = textLines [currentLine];

		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			currentLine += 1;
		}
	}

}
