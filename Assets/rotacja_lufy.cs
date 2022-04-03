using UnityEngine;
using System.Collections;

public class rotacja_lufy : MonoBehaviour {


	public Transform target;

	public float speed;
	public float dlugosc = 90.0f;
	//public Vector3 wektorek;

	void Start () {

	}
	void Update() {
		Vector3 targetDir = target.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, dlugosc);
		//newDir.z = 0.0f;
		Debug.DrawRay(transform.position, newDir, Color.red);
		//transform.rotation = Quaternion.LookRotation(newDir);
	//	transform.rotation = Quaternion.LookRotation (newDir);
		//transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
	//	transform.rotation = Quaternion.RotateTowards (target.rotation, transform.rotation, 0);
		//transform.rotation = Quaternion.LookRotation (target.position - transform.position);
		transform.LookAt(target);
		//transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 2.0f);
	}
	}

