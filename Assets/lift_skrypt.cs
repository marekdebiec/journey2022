using UnityEngine;
using System.Collections;

public class lift_skrypt : MonoBehaviour {

	public bool ciag;
	public bool dodolu;
	// Use this for initialization
	void Start () {
		ciag = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > 41.8f) {
			ciag = false;
		}
		if (transform.position.y < 2.5f) {
			ciag = true;
			dodolu = false;
		}
		if (dodolu) {
			transform.Translate(0, -2 * Time.deltaTime , 0);
		}

	}
	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player") {
			if (ciag) {

				transform.Translate(0, 2 * Time.deltaTime , 0);
			}
		}
	}
	void OnTriggerEnter2D (Collider2D other) {
		GetComponent<AudioSource>().Play();
	}
	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Player") {
			dodolu = true;
			GetComponent<AudioSource>().Stop();
			//if (ciag) {

			//}
		}
	}
}
