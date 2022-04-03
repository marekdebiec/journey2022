using UnityEngine;
using System.Collections;

public class przepasc : MonoBehaviour {
//	GameObject aa;
//	GameObject bb;
//	GameObject cc;
	//public Rigidbody2D rigidbdy;
	public GameObject player;
	//public GameObject PlayerO1;
	//public GameObject[] obiektyGry;
	public float  newAlpha = 0.5f;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("baloon");
		//PlayerO1 = GameObject.Find("hero");
		//rigidbdy = player.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
//		aa = GameObject.Find("a");
//		bb = GameObject.Find("b");
//		cc = GameObject.Find("c");
	}



	void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "baloon") {
			if (player.GetComponent<balonStart>().isHit == true) {
				other.GetComponent<balonStart>().duch = true;	
			}
		}
		if (other.tag == "baloon") {
		 if (player.GetComponent<balonStart>().isHit == false) {
			//gameObject.GetComponent<AudioSource>().Play();
//			if (aa != null) 
//			{
//				Destroy(aa);
//			}
//			else if (bb != null) {
//				Destroy (bb);
//			}
//			else if (cc != null) {
//				Destroy (cc);
//				Application.LoadLevel("game_over");
//			}

				//rigidbdy.isKinematic = true;
			

				other.transform.Translate(Vector2.up *20);
			//	player.GetComponent<Renderer>().material.color = new Color(player.GetComponent<Renderer>().material.color.r, player.GetComponent<Renderer>().material.color.g, player.GetComponent<Renderer>().material.color.b, newAlpha);
			//	other.GetComponent<balonStart>().duch = true;	
			//	foreach ( GameObject lll in obiektyGry) {

				//	lll.GetComponent<Renderer>().material.color = new Color(lll.GetComponent<Renderer>().material.color.r, lll.GetComponent<Renderer>().material.color.g, lll.GetComponent<Renderer>().material.color.b, newAlpha);
//					StartCoroutine( Wait (5.0f));
//					lll.GetComponent<Renderer>().material.color = new Color(lll.GetComponent<Renderer>().material.color.r, lll.GetComponent<Renderer>().material.color.g, lll.GetComponent<Renderer>().material.color.b, 1.0f);
					//StartCoroutine( Wait (.1f));

				//}
				//StartCoroutine("Fade2",5.0f);
			}

		}
}
//	IEnumerator Wait(float seconds)
//	{
//		Debug.Log ("Wait");
//		yield return new WaitForSeconds(seconds);    
//	}
//	IEnumerator Fade2(float waitTime) {
//		foreach ( GameObject lll in obiektyGry) {
//			
//			lll.GetComponent<Renderer>().material.color = new Color(lll.GetComponent<Renderer>().material.color.r, lll.GetComponent<Renderer>().material.color.g, lll.GetComponent<Renderer>().material.color.b, newAlpha);
//			yield return new WaitForSeconds(.1f);
//			lll.GetComponent<Renderer>().material.color = new Color(lll.GetComponent<Renderer>().material.color.r, lll.GetComponent<Renderer>().material.color.g, lll.GetComponent<Renderer>().material.color.b, 1.0f);
//			yield return new WaitForSeconds(.1f);
//			//yield return null;
//		}
//	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "baloon") {
			player.GetComponent<balonStart>().isHit = false;
			
		}
	}
}
