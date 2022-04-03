using UnityEngine;
using System.Collections;

public class wystrzal : MonoBehaviour {
	public GameObject target;
	//public GameObject lufaa;
	public float speed;
	//Vector3 pozycja;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("centerBaloon");
	//	lufaa = GameObject.Find ("lufa");
		transform.LookAt(target.transform);
	//	transform.eulerAngles = new Vector3(transform.rotation.x, lufaa.transform.rotation.y, transform.rotation.z);
		//transform.eulerAngles = new Vector3(0, 0, lufaa.transform.position.x + 400);
	//	transform.rotation.y = 
	//	pozycja = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.left * Time.deltaTime * speed);
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	//	float step = speed * Time.deltaTime;
	//	transform.Translate (-10 * Time.deltaTime, 0, 0);
		//transform.Translate(Vector3.forward * Time.deltaTime);
	//	transform.position = Vector3.MoveTowards(transform.position, pozycja, step);
		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);

		if (transform.position.y < 0) {
			Destroy(gameObject);
		}
	}
//	void OnTriggerEnter2D (Collider2D other) {
//		if (other.tag == "Player") {
//			Destroy (gameObject);
//		}
//		if (other.tag == "enemy") {
//			Destroy (gameObject);
//		}
//	}
}
