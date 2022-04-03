using UnityEngine;
using System.Collections;

public class ButtonCharacter : MonoBehaviour 
{

	public bool plec;

	void Awake () {
		// Do not destroy this game object:
		
		DontDestroyOnLoad(this);
	}
	public void NextLevelButton2(int index)
	{
		Application.LoadLevel(index);
	}
	
//	public void NextLevelButton2(string levelName)
//	{
//		Application.LoadLevel(levelName);
//	}
	public void NextLevelButton2(string rodzaj)
	{
		if (rodzaj == "ona") {
			plec = false;
		}
		if (rodzaj == "on") {
			plec = true;
		}
	}
}