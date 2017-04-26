using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    float Timer = 0f;
    public Text ItemCounter;
    public Text loseText;
    public Text reloadText;


    GameObject Player;

    float _Timer = 0f;
    float _Timer_ = 0f;


    private void Start()
    {
        SetCountText();
        loseText.text = "";
        Player = GameObject.Find("Sphere Collider");
    }

    void Update()
    {
        SetCountText();

        if(StaticHolder.PlayerDied == false)
        {
            Timer += Time.deltaTime;
        }

       
    }

    void SetCountText()
    {
        ItemCounter.text = "" + StaticHolder.ItemCounter;
        if (StaticHolder.PlayerDied == true)
        {
            loseText.text = "MOST GRUESOME DEATH!";
        }
        if (StaticHolder.PlayerDied == true)
        {
            reloadText.text = "PRESS R TO RELOAD, YO!";
        }
    }
}
