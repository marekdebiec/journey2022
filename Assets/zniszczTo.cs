using UnityEngine;
using System.Collections;

public class zniszczTo : MonoBehaviour {


	public GameObject zniszczenie999;
	public GameObject zniszczenie888;
	public GameObject zniszczenie777;

	void Awake () {
		zniszczenie999 = GameObject.Find ("a");
		zniszczenie888 = GameObject.Find ("b");
		zniszczenie777 = GameObject.Find ("c");
	}
	// Use this for initialization
	void Start () {
		if (zniszczenie999 != null) {
			Destroy (zniszczenie999);
		}
		if (zniszczenie888 != null) {
			Destroy (zniszczenie888);
		}
		if (zniszczenie777 != null) {
			Destroy (zniszczenie777);
		}
	}
	

}
