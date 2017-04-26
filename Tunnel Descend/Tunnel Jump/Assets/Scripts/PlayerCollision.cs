using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public GameObject Explosion;

    public AudioClip ItemGet;
    public AudioSource audio;

    private void Awake()
    {
        //Explosion.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            //Explosion.SetActive(true);
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            StaticHolder.PlayerDied = true;
            GetComponent<MeshRenderer>().enabled = false;
        }
        if (other.tag == "Item")
        {
            StaticHolder.ItemCounter+=1;
            audio.pitch = 1;
            audio.PlayOneShot(ItemGet, 1f);
               
        }
    }
        

    
}


