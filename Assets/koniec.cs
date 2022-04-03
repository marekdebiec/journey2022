using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koniec : MonoBehaviour
{
    public GameObject jojstik;

    // Start is called before the first frame update
    void Start()
    {
        jojstik = GameObject.Find("/Canvas/Fixed Joystick");
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(jojstik);
    }
}
