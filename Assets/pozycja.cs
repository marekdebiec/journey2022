using UnityEngine;
using System.Collections;

public class pozycja : MonoBehaviour {
	public Camera kamera;	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (kamera.transform.position.x, transform.position.y);
	}
}
