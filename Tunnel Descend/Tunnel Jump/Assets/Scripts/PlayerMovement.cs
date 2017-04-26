using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(StaticHolder.PlayerDied == false)
        {
            if (Input.GetAxis("Horizontal") < 0)
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
        if(Input.GetKeyDown("r"))
        {
            StaticHolder.PlayerDied = false;
            StaticHolder.ItemCounter = 0;
            SceneManager.LoadScene("Scenes/gameScreen");
        }
        
    }
}
