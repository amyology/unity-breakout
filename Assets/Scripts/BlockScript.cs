﻿using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D other){
		Destroy (gameObject);
	}
}
