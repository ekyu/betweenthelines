﻿using UnityEngine;
using System.Collections;

public class testEnemy: MonoBehaviour{

    public GameObject player;
    public float distance;
    public Transform myTransform;
    public float moveSpeed;
    public GameObject attack;
    public float timer;
    public float toHit;
  


    void Start()
    {
        timer = 0;
        player = GameObject.Find("Player");
        myTransform = gameObject.transform;
       
        toHit = 0;
    }


    // Update is called once per frame
    void Update () {

        moveSpeed = gameObject.GetComponent<enemy>().movespeed;

        distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance <= 15)
        {
            if (player.transform.position.z > myTransform.position.z)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else transform.eulerAngles = new Vector3(0, -180, 0);
        }
        if (distance <= 10 && distance > 5) 
        {
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
        if (distance <= 5)
        {
            timer += Time.deltaTime;
            toHit++;
            if (toHit >= 75)
            {
                if(this.gameObject.GetComponent<enemy>().EnemyRed == player.gameObject.GetComponent<player>().red)
                {
                    hitStart(myTransform.position, myTransform.rotation);
                    toHit = 0;
                }
               
            }
        }
    }

    public void hitStart(Vector3 pos, Quaternion angle)
    {

        Instantiate(attack, pos, angle);
    }
}
