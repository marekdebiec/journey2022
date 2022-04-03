using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(PlatformerCharacter2D2))]
public class Platformer2DUserControl2 : MonoBehaviour 
{
    private Vector3 position;
    private float width;
    private float height;
    private bool jump;
    private PlatformerCharacter2D2 character;
   // public float b = 0f;
   
   public Joystick joystick;

    void Awake()
    {
        character = GetComponent<PlatformerCharacter2D2>();
        height = (float)Screen.height / 2.0f;
        width = (float)Screen.width / 2.0f;
    }

    void Update()
    {
        float verticalMove = joystick.Vertical;
      //  if (Input.GetButtonDown("Fire2")) jump = true;
       // if (Input.GetButtonDown("Jump")) jump = true;
        if (verticalMove >= .5f) jump = true;
       
        // Handle screen touches.
        // if (Input.touchCount > 0)
        // {

        //  Touch touch = Input.GetTouch(0);

        //  if (touch.phase == TouchPhase.Moved && Input.GetTouch(0).position.y < height)
        // {
        //     Vector2 pos = touch.position;
        //      pos.x = (pos.x - width) / width;
        //      b = pos.x;


        //  }
        // float h = b;

        // // if (Input.GetButtonDown("Fire1")) jump = true;
        // if (Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.y > height) jump = true;


        //  character.Move(h, jump);
        // }



    }
    void FixedUpdate()
    {
       
        //float h = Input.GetAxis("Horizontal");
        float h = joystick.Horizontal;
        // Pass all parameters to the character control script.

        character.Move(h, jump);
        // Reset the jump input once it has been used.
        jump = false;
    }
}
