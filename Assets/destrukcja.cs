using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class destrukcja : MonoBehaviour {
	//int score;
	//public Text nowyText;
	//public Text wynik;
	public string tekst;
	public GameObject papirus;
	private reseter yetAnotherScript;
	GameObject cus;
	GameObject cus2;
	Text okno;
	Text okno2;



	void Start () {
		//papirus = GameObject.Find ("papirus");
		cus = GameObject.Find("Text");
		cus2 = GameObject.Find("Text 1");
		okno = cus.GetComponent<Text> ();
		okno2 = cus2.GetComponent<Text> ();
	}
	

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			transform.parent.GetComponent<AudioSource>().Play ();

			papirus.SetActive(true);
			papirus.GetComponent<papirus>().StartCoroutine("migniecie");
			//nowyText.text = (tekst);
			okno.text = (tekst);
			cus2.GetComponent<wynikPoczatek>().score++;
			//wlacz animacje napisu 
			cus.GetComponent<Animator>().enabled = true;
			//wynik.text = "SCORE: " + score;

			//okno2.text = "SCORE: " + score;


			//yetAnotherScript = nowyText.GetComponent<reseter>();
			yetAnotherScript = cus.GetComponent<reseter>();
			yetAnotherScript.akcja = true;
			Destroy (gameObject);

		}
	}

//	IEnumerator ShowMessage ( float delay) {
//		//nowyText.text = ("Mam prawo do nauki");
//		okno.text = (tekst);
//		yield return new WaitForSeconds(delay);
//		okno.text = ("");
//		//nowyText.text = ("");
//
//	}

}
