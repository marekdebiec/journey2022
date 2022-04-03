using UnityEngine;
using System.Collections;

public class papirus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//StartCoroutine("migniecie");
	}
	

	IEnumerator migniecie () {
		gameObject.SetActive (true);
		yield return new WaitForSeconds (5f);
		gameObject.SetActive (false);
	}
}
