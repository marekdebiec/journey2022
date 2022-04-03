using UnityEngine;
using System.Collections;

public class ship : MonoBehaviour {

	public GameObject player;
	public bool jedziesz;
	public float odleglosc = 1338.0f;
	public float dyst000 = 48.0f;
	public GameObject lufa;
	public GameObject obiekt;
	//public float distancee;
	//public kule_ship kuleSkrypt;
	//public GameObject other000;
	public GameObject kule;
	// Use this for initialization
	void Start () {

		//kuleSkrypt = other000.GetComponent<kule_ship> ();
		//kuleSkrypt.enabled = false;
		//distancee = Vector2.Distance (transform.position, player.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find("hero");
		//Debug.Log (player.transform.position.x);
		if (player.transform.position.x > 1130.0f) {
			//transform.Translate (1.5f * Time.deltaTime, 0, 0);
			jedziesz = true;
		}
		if (transform.position.x > odleglosc) {
			//jedziesz = false;
			//Destroy ( kuleSkrypt);
			//kule.GetComponent<Animator>().enabled = false;
			Destroy (kule);
			obiekt.GetComponent<rotacja_lufy> ().enabled = false;
			Destroy (this);
		}
		if (jedziesz) {
			lufa.GetComponent<kule_ship> ().enabled = true;
			//	kuleSkrypt.enabled = true;
			//transform.Translate (1.5f * Time.deltaTime, 0, 0);
			if (player.transform.position.x + dyst000 < transform.position.x) {
				//Debug.Log("ggg");
				transform.Translate (-10.0f * Time.deltaTime, 0, 0);
			} else {
				transform.position = new Vector2 (player.transform.position.x + dyst000, transform.position.y);
			}
		} 
	}
}
