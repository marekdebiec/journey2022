using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;


[RequireComponent(typeof(PlatformerCharacter2D))]
public class Platformer2DUserControl : MonoBehaviour 
{
	private Vector2 position;
	private float width;
	private float height;
	float b = 0f;
	float c;

	private PlatformerCharacter2D character;
    private bool jump;
	public float zmiennaTa = .2f; //od 0 do 1 !
	public Joystick joystick;

	void Awake()
	{
		character = GetComponent<PlatformerCharacter2D>();
		width = (float)Screen.width / 2.0f;
		height = (float)Screen.height / 2.0f;
	}

    void Update ()
    {
		
		// Read the jump input in Update so button presses aren't missed.
#if CROSS_PLATFORM_INPUT
        if (CrossPlatformInput.GetButtonDown("Jump")) jump = true;
		
#else
		//if (Input.GetButtonDown("Jump")) jump = true;
		//if (Input.GetButtonDown("Fire1")) jump = true;


#endif
	}

	void FixedUpdate()
	{
		float verticalMove = joystick.Vertical;
		if (verticalMove >= zmiennaTa) jump = true;
		// Read the inputs.

		//bool crouch = Input.GetKey(KeyCode.LeftControl);

#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis("Horizontal");
#else

		//float h = Input.GetAxis("Horizontal");

		float h = joystick.Horizontal; 
		
		//float h = b;
		//float h = CrossPlatformInputManager.GetAxis("Horizontal");
		//float h = mjoystick.Horizontal;
#endif

		// Pass all parameters to the character control script.
		//character.Move(h, crouch, jump);
		character.Move(h, jump);
		// Reset the jump input once it has been used.
		jump = false;
	}
	
}
