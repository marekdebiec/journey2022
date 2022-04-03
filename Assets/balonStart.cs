using UnityEngine;
using System.Collections;

public class balonStart : MonoBehaviour {
	public bool isEnter;
	public bool duch;
	public Animator animator;
	public Rigidbody2D rigidbdy;
	public Rigidbody2D rigidbdy333;
	public GameObject player;
	public GameObject spod0;
	private PlatformerCharacter2D yetAnotherScript2;
	private Platformer2DUserControl yetAnotherScript3;
	private Camera2DFollow yetAnotherScript4;
	public Transform centerek;
	public Joystick joystick;
	float min = -16.5f;
	 float max = 36.5f;
	 float zmienna = 26.3f;
	public float gora = 49.3f;
	public float dol = 14.5f;	
	public float zoom = 14.0f;
	public bool isHit;
	private bool zmienna2 = true;

	void Update () {
		animator = gameObject.transform.GetComponent<Animator>();
		player = GameObject.Find("hero");
		rigidbdy = player.GetComponent<Rigidbody2D> ();
		rigidbdy333 = gameObject.GetComponent<Rigidbody2D> ();
		centerek = this.gameObject.transform.GetChild(0);

		if (transform.position.x > 1362.0f) {
			Ladowanie();
		}
	
		if (isHit) {
			dol = 0.0f;
		}
	
		float verticalMove = joystick.Vertical; 

		float h = joystick.Horizontal; 
		if (isEnter) {
			Camera.main.orthographicSize= zoom;
			if (verticalMove > 0) {
				if (!isHit)
				{
					transform.Translate(0, 10 * Time.deltaTime, 0);
				}
			};
			if (verticalMove < 0)
			{
				if (!isHit)
				{
					transform.Translate(0, -10 * Time.deltaTime, 0);
				}
			};
			if (h > 0)
			{
				if (!isHit)
				{
					transform.Translate(10 * Time.deltaTime, 0, 0);
				}
			};
			if (h < 0)
			{
				if (!isHit)
				{
					transform.Translate(-10 * Time.deltaTime, 0, 0);
				}
			};
			//if (Input.GetKey(KeyCode.W)) {
			//	if (!isHit) {
			//		transform.Translate(0,10 * Time.deltaTime,0);
			//	}
			//}
			//if (Input.GetKey(KeyCode.UpArrow)) {
			//	if (!isHit) {					
			//		transform.Translate(0,10 * Time.deltaTime,0);					
			//	}
			//}
			//if (Input.GetKey(KeyCode.S)) {
			//	if (!isHit) {
			//		transform.Translate(0,-10 * Time.deltaTime,0);
			//	}
			//}
			//if (Input.GetKey(KeyCode.DownArrow)) {
			//	if (!isHit) {
			//		transform.Translate(0,-10 * Time.deltaTime,0);					
			//	}
			//}
			//if (Input.GetKey(KeyCode.D)) {
			//	if (!isHit) {
			//		transform.Translate(10 * Time.deltaTime,0,0);
			//	}
			//}
			//if (Input.GetKey(KeyCode.RightArrow)) {
			//	if (!isHit) {
			//		transform.Translate(10 * Time.deltaTime,0,0);
			//	}
			//}
			//if (Input.GetKey(KeyCode.A)) {
			//	if (!isHit) {
			//		transform.Translate(-10 * Time.deltaTime,0,0);
			//	}
			//}
			//if (Input.GetKey(KeyCode.LeftArrow)) {
				//if (!isHit) {
				//	transform.Translate(-10 * Time.deltaTime,0,0);
			//	}
			//}

			//ruch w prawo
			if (!isHit) {
				transform.Translate (1.5f * Time.deltaTime, 0, 0);
			}
			player.transform.position = centerek.transform.position; //pozycja gracza taka sama jak obiekt Centerek balonu
			if (isHit) //ruch w dol gdy zostanie trafiony
            {
				transform.Translate(0, -5f * Time.deltaTime, 0);
			}
		}

		//granica dol?
		if (transform.position.y<= dol){
							
								transform.position = new Vector2 ( transform.position.x, dol);
							}
		//granica gora
		if (transform.position.y>= gora){
			transform.position = new Vector2 ( transform.position.x, gora);

							}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {

			if (zmienna2) DoGory ();
			isEnter = true;
			rigidbdy.isKinematic = true;
			yetAnotherScript2 =  player.GetComponent<PlatformerCharacter2D>();
			yetAnotherScript2.enabled = false;
			yetAnotherScript3 =  player.GetComponent<Platformer2DUserControl>();
			yetAnotherScript3.enabled = false;
			yetAnotherScript4 = Camera.main.GetComponent<Camera2DFollow>();
			yetAnotherScript4.lookAheadFactor = 18;
			yetAnotherScript4.lookAheadMoveThreshold = -30;
		}

		

	}
	IEnumerator isInvisible2 () {
		duch = true;
		yield return new WaitForSeconds (5.0f);
		duch = false;
	}
	//balonik unusi sie do gory kiedy gracz wchodzi do niego
	void DoGory () {
		
		transform.Translate (0,1 * Time.deltaTime * 100, 0 , Space.World); //do gory
		zmienna2 = false; //odlaczam ta funkcje
	}
	//lądowanie
	void Ladowanie () {
		isEnter = false;
		rigidbdy.isKinematic = false;
		yetAnotherScript2 =  player.GetComponent<PlatformerCharacter2D>();
		yetAnotherScript2.enabled = true;
		yetAnotherScript3 =  player.GetComponent<Platformer2DUserControl>();
		yetAnotherScript3.enabled = true;
		yetAnotherScript4 = Camera.main.GetComponent<Camera2DFollow>();
		yetAnotherScript4.lookAheadFactor = 3.0f;
		yetAnotherScript4.lookAheadMoveThreshold = 0.1f;
		Destroy (GetComponent<EdgeCollider2D> ());
		spod0.SetActive (true);

		rigidbdy333.isKinematic = false;
		Camera.main.orthographicSize= 14.0f;  
		Destroy (this);
	}

	}

