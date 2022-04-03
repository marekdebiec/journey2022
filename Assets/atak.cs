using UnityEngine;
using System.Collections;
// powoduje , ze samolot leci w lewo (atakuje) i wlacza sie dzwiek samolotu 
public class atak : MonoBehaviour {
	float dystans;
	public float speed = 5.0f;
	GameObject balon;
	Transform dziecko;
	

//	public GameObject autodestrukcja;
	// Use this for initialization
	void Start () {
		balon = GameObject.FindWithTag ("baloon");
		dziecko = this.gameObject.transform.GetChild(0);

	}
	
	// Update is called once per frame
	void Update () {
		float dystans = Vector2.Distance(balon.transform.position , transform.position);
//		float dystans2 = Vector2.Distance(autodestrukcja.transform.position , transform.position);
		//Debug.Log (dystans);
		if (dystans < 45) {
			transform.Translate(-Vector2.right * speed * Time.deltaTime);
			dziecko.GetComponent<AudioSource>().Play();
			
		}
//		if (dystans2 < 5) {
//			Destroy (gameObject);
//		}
	}
}
