using UnityEngine;
using System.Collections;

public class kule_ship : MonoBehaviour {

	public GameObject player;
	public Transform prefab;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("hero");
		StartCoroutine ("Strzal");
	}
	
	// Update is called once per frame
	void Update () {
//		if (player.transform.position.x > 1148.2f) {
//
//		
//		}

	}

	IEnumerator Strzal() {

			
		//for (;;) {
		//for (int i = 0; i < 2; i++) {
			//Instantiate (prefab, gameObject.transform.position, Quaternion.identity);
		for (int i = 0; i < 100; i++) {

			Instantiate (prefab, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			yield return new WaitForSeconds (5);
		}
		//}
		//}

	}

}
