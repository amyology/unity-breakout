using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

	public GameControllerScript controller;

	void OnCollisionEnter2D (Collision2D other){
		Destroy (gameObject);
		controller.AddPoints (10);
	}
}
