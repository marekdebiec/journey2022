using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wynikPoczatek : MonoBehaviour {

	Text wynik2;
	public int score = 0;
	// Use this for initialization
	void Start () {
		wynik2 = GetComponent<Text> ();
//		wynik2.text = "SCORE: " + score;
}
	void Update () {
		//wynik2.text = "SCORE: " + score;
		wynik2.text = " " + score;
	}

}
