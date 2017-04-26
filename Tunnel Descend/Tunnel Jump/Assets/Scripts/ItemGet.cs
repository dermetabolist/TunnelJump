using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour {

    private void Start()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
