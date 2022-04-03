using UnityEngine;
using System.Collections;

public class korekcja : MonoBehaviour {


	public Transform target; //pkt
	public Transform target222; //pkt2
								//public float speed;

	void Awake()
    {
		
	}
	void Update ()
    {
		//target = transform.Find("pkt");
		

	}
	void OnTriggerEnter2D (Collider2D other) {
		target = GameObject.Find("start_position/hero/pkt").transform;
		target222 = GameObject.Find("start_position/hero/pkt2").transform;
		if (other.tag == "Player") {
			//target.transform.position = new Vector3 (transform.position.x , -.1f , 0);
			if (target != null) target.transform.Translate(0 , -5f , 0);
			if (target222 != null) target222.transform.Translate(0 , -5f , 0);
		}
	}
}
