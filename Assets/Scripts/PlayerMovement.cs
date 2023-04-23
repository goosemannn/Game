using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = .01F;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(.01F*Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-.01F*Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, .01F*Time.deltaTime, 0));
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, -.01F*Time.deltaTime, 0));
        }
    }
}