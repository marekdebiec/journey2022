using UnityEngine;
using System.Collections;

public class spawn_woda_cs : MonoBehaviour {

	public Transform SpawnPoint;
	private GameObject Player;
	private GameObject aa;
	private GameObject bb;
	private GameObject cc;

	
	// Update is called once per frame
	void Update () {
		Player = GameObject.FindWithTag ("Player");

		aa = GameObject.Find("a");//serce
		bb = GameObject.Find("b");
		cc = GameObject.Find("c");
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			
			
			//other.GetComponent.<AudioSource>().Play();
			gameObject.GetComponent<AudioSource>().Play();
			//Destroy ( serce );
			if (aa != null) 
			{
				Destroy(aa);
			}
			else if (bb != null) {
				Destroy (bb);
			}
			else if (cc != null) {
				Destroy (cc);
				Application.LoadLevel("game_over");
			}
		
			if (SpawnPoint != null) {
				Player.transform.position = SpawnPoint.position;
			}
			
		}
	}
}
