using UnityEngine;
using System.Collections;

public class ladder : MonoBehaviour {

	bool isClimbing;
	GameObject player;
	Rigidbody2D rigidbdy;
	
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find("hero");
		rigidbdy = player.GetComponent<Rigidbody2D> ();

		if (isClimbing) {
			if (Input.GetKey(KeyCode.UpArrow)) {
				player.transform.Translate(0,10 * Time.deltaTime,0);
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				player.transform.Translate(0, -10 * Time.deltaTime, 0);
			}
			if (Input.GetKey(KeyCode.W)) {
				player.transform.Translate(0,10 * Time.deltaTime,0);
			}
			if (Input.GetKey(KeyCode.S)) {
				player.transform.Translate(0,-10 * Time.deltaTime,0);
			}
			if (Input.GetButtonDown("Fire1")) player.transform.Translate(0,10 * Time.deltaTime,0); //18.12.2021

		}
	}
	void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "Player") {
			rigidbdy.isKinematic = true;
			isClimbing = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		
			rigidbdy.isKinematic = false;
			isClimbing = false;
		
	}
}
