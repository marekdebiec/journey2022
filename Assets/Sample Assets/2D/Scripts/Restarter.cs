using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
			//The name of the level that was last loaded (Read Only).
			Application.LoadLevel(Application.loadedLevelName);
	}
}
