using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Transform Explosion;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            StaticHolder.PlayerDied = true;
            Destroy(gameObject);
        }
    }
}
