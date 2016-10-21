using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

	public GameObject paddle;
	public Rigidbody2D paddleRb;
	int paddlespeed = 20;

	int launchspeed = 40;
	public bool isActive;

	public GameObject ballPrefab;
	GameObject newBall;

	void Start () {
		isActive = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Launch ();
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			paddleRb.velocity = new Vector2 (-paddlespeed, 0);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			Stop ();
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			paddleRb.velocity = new Vector2 (paddlespeed, 0);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			Stop ();
		}
	}

	void Stop () {
		paddleRb.velocity = new Vector2 (0, 0);
	}

	void Launch () {
		if (isActive == false) {
			GameObject newBall = Instantiate (ballPrefab) as GameObject;

			Rigidbody2D newBallRb = newBall.GetComponent<Rigidbody2D>();
			newBallRb.velocity = new Vector2 (0, launchspeed);
			isActive = true;
		}
	}
}
