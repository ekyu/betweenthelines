﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class levelselectscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        SceneManager.LoadScene("levelselect");
    }
}