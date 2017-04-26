using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour {

    public AudioSource audio;
    public AudioClip GameOver;
    bool playsound = true;
	
	// Update is called once per frame
	void Update ()
    {
		if(StaticHolder.PlayerDied == true && playsound == true)
        {
            audio.clip = GameOver;
            audio.loop = false;
            audio.PlayOneShot(GameOver, 1f);
            playsound = false;
        }
	}
}
