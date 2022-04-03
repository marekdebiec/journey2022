using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class reseter : MonoBehaviour {

	public bool akcja;
	Text nowyText3;

	
	// Update is called once per frame
	void Update () {
		if (akcja) {

				StartCoroutine(Message(5f));
			}
	}

	IEnumerator Message ( float delay) {
		nowyText3 = GetComponent<Text> ();
		yield return new WaitForSeconds(delay);
		nowyText3.text = " ";
		akcja = false;
	}
}
