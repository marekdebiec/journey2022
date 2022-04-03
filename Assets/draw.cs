using UnityEngine;
using System.Collections;

public class draw : MonoBehaviour {


	public bool duch0;
	//RaycastHit hit;
	public GameObject[] obiektyGry;
	void Update () {
	//	Ray ray = new Ray(transform.position, Vector3.up * 100);
	//	Ray ray2 = new Ray(transform.position, Vector3.down * 100);
		//if (Physics.Raycast(ray, out hit)){		
				//hit.collider.GetComponent<scroler>().minal = true;
		//	hit.collider.GetComponent<scroler_lepszy>().minal = true;		
		//}
		//if (Physics.Raycast(ray2, out hit)){		
			//hit.collider.GetComponent<scroler>().minal = true;
		//	hit.collider.GetComponent<scroler_lepszy>().minal = true;		
		//}
		if (duch0) {
//			foreach (GameObject lll in obiektyGry) {
//				lll.GetComponent<Renderer> ().material.color = new Color (lll.GetComponent<Renderer> ().material.color.r, lll.GetComponent<Renderer> ().material.color.g, lll.GetComponent<Renderer> ().material.color.b, 0.5f);
//			}
			StartCoroutine("miganie");
		}
		else if (!duch0) {
			foreach (GameObject lll in obiektyGry) {
				lll.GetComponent<Renderer> ().material.color = new Color (lll.GetComponent<Renderer> ().material.color.r, lll.GetComponent<Renderer> ().material.color.g, lll.GetComponent<Renderer> ().material.color.b, 1.0f);
			}
		}
	
	}
	IEnumerator miganie () {
		foreach (GameObject lll in obiektyGry) {
			lll.GetComponent<Renderer> ().material.color = new Color (lll.GetComponent<Renderer> ().material.color.r, lll.GetComponent<Renderer> ().material.color.g, lll.GetComponent<Renderer> ().material.color.b, 1.0f);
		}
		yield return new WaitForSeconds (1.5f);
		foreach (GameObject lll in obiektyGry) {
			lll.GetComponent<Renderer> ().material.color = new Color (lll.GetComponent<Renderer> ().material.color.r, lll.GetComponent<Renderer> ().material.color.g, lll.GetComponent<Renderer> ().material.color.b, 0.5f);
		}
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "enemy") {
			StartCoroutine ("isInvisible");
			}
		}
	IEnumerator isInvisible () {
		yield return new WaitForSeconds (.1f);
		duch0 = true;
		yield return new WaitForSeconds (5.0f);
		duch0 = false;
	}

}
