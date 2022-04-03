using UnityEngine;
using System.Collections;

public class korekcja2 : MonoBehaviour {


	public Transform target; //pkt
	public Transform target333; //pkt2
	public float speed;

	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		
		
	}
	void OnTriggerEnter2D (Collider2D other) {
		target = GameObject.Find("start_position/hero/pkt").transform;
		target333 = GameObject.Find("start_position/hero/pkt2").transform;
		if (other.tag == "Player") {
			//target.transform.position = new Vector3 (transform.position.x , -.1f , 0);
			if (target != null) { target.transform.Translate(0, 1f * speed, 0); }

			if (target333 != null) { target333.transform.Translate(0, 1f * speed, 0); }
		}
	}
}
