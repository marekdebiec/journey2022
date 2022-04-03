using UnityEngine;
using System.Collections;

public class destroy000 : MonoBehaviour {

	public GameObject zniszczenie ;
	public GameObject zniszczenie222 ; 
	// Use this for initialization
	void Start () {
		zniszczenie = GameObject.Find ("Canvas");
		zniszczenie222 = GameObject.Find ("tajne");
		Destroy (zniszczenie);
		Destroy (zniszczenie222);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
