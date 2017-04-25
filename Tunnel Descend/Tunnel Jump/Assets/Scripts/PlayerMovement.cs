using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 0.2f;
	void Start ()
    {
		
	}
	
	void Update ()
    {
        Controls();
	}

    void Controls()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.left * -speed);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.up * speed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector3.up * -speed);
        }
    }
}
