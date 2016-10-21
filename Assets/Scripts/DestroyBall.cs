using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	public GameControllerScript controller;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		Destroy (other.gameObject);
		controller.isActive = false;
	}
}
