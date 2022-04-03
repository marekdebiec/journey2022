using UnityEngine;
using System.Collections;

public class lotMotyla : MonoBehaviour {

	public GameObject player;
	public float speed  = 5.0f;
	public bool jestBlisko;
	public float dystans2;
	//public float rotSpeed  = 50.0f;
	Vector3 vel;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		player = GameObject.Find("hero");
		//transform.Translate(Vector3.left * Time.deltaTime);
		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);

		dystans2 = Vector2.Distance(player.transform.position , transform.position);
		if (dystans2 < 25) {
			jestBlisko = true;
		}
		vel = Random.insideUnitSphere * speed;
		vel.z = 0.0f;
		if (jestBlisko) {
			transform.Translate (vel * Time.deltaTime);
		}


	


		//transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
	}
}
