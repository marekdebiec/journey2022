using UnityEngine;

public class PlatformerCharacter2D2 : MonoBehaviour 
{
    bool facingRight = true;							// For determining which way the player is currently facing.
    public bool grounded = false;                              // Whether or not the player is grounded.
    Animator anim;										// Reference to the player's animator component.
    [SerializeField] float jumpForce = 400f;			// Amount of force added when the player jumps.	
    Transform groundCheck;                              // A position marking where to check if the player is grounded.
    Transform ceilingCheck;								// A position marking where to check for ceilings
    float groundedRadius = .2f;							// Radius of the overlap circle to determine if grounded
    [SerializeField] LayerMask whatIsGround;			// A mask determining what is ground to the character
    [SerializeField] float maxSpeed = 10f;              // The fastest the player can travel in the x axis.
    [SerializeField] public bool airControl = false;			// Whether or not a player can steer while jumping;
    void Awake()
    {
        // Setting up references.
        groundCheck = transform.Find("GroundCheck");
        ceilingCheck = transform.Find("CeilingCheck");
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        // Set the vertical animation
        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);
    }
    public void Move(float move, bool jump)
    {


        //only control the player if grounded or airControl is turned on
        if (grounded || airControl)
        {
            // Reduce the speed if crouching by the crouchSpeed multiplier
            //move = (crouch ? move * crouchSpeed : move);

            // The Speed animator parameter is set to the absolute value of the horizontal input.
            anim.SetFloat("Speed", Mathf.Abs(move));

            // Move the character
            GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

            // If the input is moving the player right and the player is facing left...
            if (move > 0 && !facingRight)
                // ... flip the player.
                Flip();
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (move < 0 && facingRight)
                // ... flip the player.
                Flip();
        }
        // If the player should jump...
        if (grounded && jump)
        {
            // Add a vertical force to the player.
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }
    }
    void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
