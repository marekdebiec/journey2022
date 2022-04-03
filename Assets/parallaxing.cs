using UnityEngine;
using System.Collections;

public class parallaxing : MonoBehaviour {

	//private float ParallaxScale;
	public Transform foreground;
	public float ParallaxScale = 20f;
	private Transform cam;
	private Vector3 previousCamPos;
	public float smoothing = 1f;


	void Awake () {

		cam = Camera.main.transform;
	}
	// Use this for initialization
	void Start () {
		previousCamPos = cam.position;
	}
	
	// Update is called once per frame
	void Update () {
		float parallax = (previousCamPos.x - cam.position.x) * ParallaxScale;

		float foregroundTargetPosX = foreground.position.x + parallax;

		Vector3 foregroundTargetPos = new Vector3 (foregroundTargetPosX , foreground.position.y, foreground.position.z);
		//transform.position = foregroundPosX;
		foreground.position = Vector3.Lerp (foreground.position, foregroundTargetPos, smoothing * Time.deltaTime);


		previousCamPos = cam.position;
	
	}
}
