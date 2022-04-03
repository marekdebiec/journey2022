using UnityEngine;
using System.Collections;

public class przepasc0 : MonoBehaviour {
	public Rigidbody2D rigidbdy;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("baloon");
		rigidbdy = player.GetComponent<Rigidbody2D> ();
	}
	

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "baloon") {
			//other.transform.GetComponent<balonStart>().isHit = false;
			other.transform.Translate(Vector2.up *20);
			rigidbdy.isKinematic = true;
		}
	}
}
