using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextImporter : MonoBehaviour {

	public TextAsset textFile;
	public string[] textLines;

	void Start()
	{
		//Check if text file is there
		if (textFile != null)
		{
			textLines = (textFile.text.Split ('\n'));

		}
	}
}
