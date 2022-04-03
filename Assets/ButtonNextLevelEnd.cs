using UnityEngine;
using System.Collections;

public class ButtonNextLevelEnd : MonoBehaviour 
{

	public GameObject zniszczenie ;
	public GameObject zniszczenie333 ; 

	public void NextLevelButton(int index)
	{
		Application.LoadLevel(index);
		zniszczenie = GameObject.Find ("Canvas");
		zniszczenie333 = GameObject.Find ("tajne");
		Destroy (zniszczenie);
		Destroy (zniszczenie333);
	}
	
	public void NextLevelButton(string levelName)
	{
		Application.LoadLevel(levelName);
		zniszczenie = GameObject.Find ("Canvas");
		zniszczenie333 = GameObject.Find ("tajne");
		Destroy (zniszczenie);
		Destroy (zniszczenie333);
	}
}