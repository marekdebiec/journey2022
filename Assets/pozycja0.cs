using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozycja0 : MonoBehaviour {

	public GameObject balon;
	
	
	// Update is called once per frame
	void Update () {
		
		transform.position = balon.transform.position;
		transform.position = new Vector3(balon.transform.position.x, transform.position.y, transform.position.z);



	}

	






}
