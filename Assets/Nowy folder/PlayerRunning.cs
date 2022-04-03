using UnityEngine;
using System.Collections;

public class PlayerRunning : MonoBehaviour
{
	[HideInInspector]
	public bool facingRight = true;
	[HideInInspector]
	public bool jump = false;
	
	public float maxSpeed = 5f;
	public float moveForce = 365f;
	public float jumpForce = 1000f;	

	private Animator anim;
	private Transform groundCheck;
	private bool grounded = false;

	void Awake() 
	{
		anim = GetComponent<Animator>();
		groundCheck = transform.Find("GroundCheck");
	}

	void Update()
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Environment"));
		if(Input.GetButtonDown("Jump") && grounded)
			jump = true;
	}
	
	void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal");

		anim.SetFloat("Speed", Mathf.Abs(horizontal));

		if (horizontal * GetComponent<Rigidbody2D>().velocity.x  < maxSpeed) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * horizontal * moveForce);
		}

		if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if(horizontal > 0 && !facingRight) {
			Flip();
		}
		else if(horizontal < 0 && facingRight) {
			Flip();
		}

		if(jump) {
			anim.SetTrigger("Jump");
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}

	void Flip ()
	{
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
