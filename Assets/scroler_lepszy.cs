using UnityEngine;
using System.Collections;

public class scroler_lepszy : MonoBehaviour {

	public float moveSpeed = 1f;
	private GameObject target;
	public bool minal;
	public float roznica = 20f;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindWithTag("Player");
		//if (!minal) {
			transform.Translate (-Vector2.right * moveSpeed * Time.deltaTime);

	//	}
		float distance = Vector2.Distance(target.transform.position, transform.position);
		//Debug.Log (distance);
		if (distance > 30f) {
			if (minal){
				transform.position = new Vector3 (target.transform.position.x + 20, target.transform.position.y + roznica, target.transform.position.z);
				minal = false;
		}
		}
		if (transform.position.x < target.transform.position.x) {
			minal = true;
		}
	}
}
