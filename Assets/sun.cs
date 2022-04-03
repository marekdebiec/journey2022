using UnityEngine;
using System.Collections;

public class sun : MonoBehaviour {

	public GameObject PlayerO;
	public float dystansO;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		PlayerO = GameObject.Find("hero");
		dystansO = Vector2.Distance(PlayerO.transform.position , transform.position);

		if (dystansO > 50) {
			transform.position = new Vector2 (PlayerO.transform.position.x + 25, transform.position.y);
		}
	}
}
