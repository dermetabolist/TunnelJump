using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsMovement : MonoBehaviour
{
    float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.up * speed);
	}
}
