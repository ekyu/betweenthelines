﻿	using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class skillPointDisplay : MonoBehaviour {

	public bool red;
	public GameObject gameManager;
	perkManager perkManager;
	Text txt;

	// Use this for initialization
	void Start () {
		perkManager = gameManager.GetComponent<perkManager>();
		txt = gameObject.GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (red) {
			txt.text = "Current skill points: " + perkManager.RedPoints;
		} else {
			txt.text = "Current skill points: " + perkManager.BluePoints;
		}
	}
}
