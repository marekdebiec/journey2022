using UnityEngine;
using System.Collections;

public class spawn_samolocik_c : MonoBehaviour {
	GameObject aa;
	GameObject bb;
	GameObject cc;
	public GameObject Player;
	public GameObject bohater;
	//public Rigidbody2D rigidbdy;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag ("baloon");
		//rigidbdy = Player.GetComponent<Rigidbody2D>() ;
	}
	// Update is called once per frame
	void Update () {	
		bohater = GameObject.Find("hero");

		aa = GameObject.Find("a"); //serce
		bb = GameObject.Find("b"); //serce
		cc = GameObject.Find("c"); //serce
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "baloon") {
			if (other.GetComponent<balonStart> ().duch == false) {
				Player.GetComponent<balonStart> ().isHit = true;
				//rigidbdy.isKinematic = false;
				other.GetComponent<balonStart>().StartCoroutine("isInvisible2");
				bohater.GetComponent<draw>().duch0 = true;

					gameObject.GetComponent<AudioSource> ().Play ();
				if (aa != null) {
					Destroy (aa);
				} else if (bb != null) {
					Destroy (bb);
				} else if (cc != null) {
					Destroy (cc);
					Application.LoadLevel ("game_over");
				}
				Destroy (this);

			}
		}
	}
}
