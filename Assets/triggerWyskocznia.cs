using UnityEngine;
using System.Collections;

public class triggerWyskocznia : MonoBehaviour {

	Animator animator;
	Collider2D coos;
	// Use this for initialization
	void Start () {
		animator = gameObject.transform.parent.GetComponent<Animator>();
		coos = this.gameObject.transform.GetChild(0).GetComponent<Collider2D>();
	}
	

	public void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			animator.SetTrigger("wyskocz");
			GetComponent<AudioSource>().Play();
			coos.enabled = true;
		//	gameObject.GetComponent<Collider2D>().enabled = false;
			//animator.SetFloat("Forward",v);
			//animator.SetFloat("Strafe",h);
			//animator.SetBool("Fire", fire);		
				//animator.SetTrigger("Die");
			//gameObject.transform.parent.GetComponent<Animation>().Play("wyskok");

		}
	}
	public void OnTriggerExit2D (Collider2D other) {
		//coos.enabled = false;
	
	}
}
