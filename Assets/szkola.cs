using UnityEngine;
using System.Collections;

public class szkola : MonoBehaviour {
//	public GameObject[] serducha;

	

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {


//			for (int i = 0; i < serducha.Length ; i++ ) {
//				serducha[i].SetActive(false);
//			}
			Application.LoadLevel ("end");
		}
	}
}
