using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sroka : MonoBehaviour {

	//public Transform other;
	
	void Update ()
    {
		//other = GameObject.Find("start_position/hero").transform;
		//float dist = Vector3.Distance(other.position, transform.position);
		//Debug.Log("Distance to other: " + dist);

		//if (dist < 25) StartCoroutine(ExampleCoroutine()); 

		//if (dist > 25) SroOut();
	}
	
	//IEnumerator ExampleCoroutine()
	//{
		//gameObject.GetComponent<AudioSource>().Play();
		//yield return new WaitForSeconds(5);
		//gameObject.GetComponent<AudioSource>().Stop();
	//}
	//void SroOut ()
   // {
		

	//}
	void OnTriggerEnter2D (Collider2D other) {
	 if (other.tag == "Player") {
			
	 		
	 		gameObject.GetComponent<AudioSource>().Play();
	 
			}
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Player") {
			gameObject.GetComponent<AudioSource>().Stop();
			
		}
	}
}
