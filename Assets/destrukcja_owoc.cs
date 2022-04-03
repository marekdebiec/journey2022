using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class destrukcja_owoc : MonoBehaviour {


	private reseter yetAnotherScript;
	GameObject otherGameObject ;
	GameObject cus2;

	Text okno2;

	void Start () {
		otherGameObject = GameObject.Find("SoundPoint");
		cus2 = GameObject.Find("Text 1");
	
		okno2 = cus2.GetComponent<Text> ();
	}
	

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
		
			otherGameObject.GetComponent<AudioSource>().Play();

			cus2.GetComponent<wynikPoczatek>().score +=  5;
	

		
			Destroy (gameObject);
		}
	}

}
