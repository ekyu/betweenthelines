﻿using UnityEngine;
using System.Collections;

public class blue1cone : MonoBehaviour {

    public int damage;
    public bool abilityred;
    public GameObject player;
    public player playerscript;
    public float despawn;

	// Use this for initialization
	void Start () {
        damage = 15;
        despawn = 1;
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

        playerscript.rooted = true;
    }
	
	// Update is called once per frame
	void Update () {


        despawn -= Time.deltaTime;

        if (despawn <= .25)
        {
            playerscript.rooted = false;
        }


        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
