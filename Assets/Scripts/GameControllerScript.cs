using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

	public GameObject paddle;
	public Rigidbody2D paddleRb;
	int paddlespeed = 20;

	int launchspeed = 40;
	public bool isActive;

	public GameObject ballPrefab;
	GameObject newBall;

	int lives = 3;
	public int points = 0;

	public Text startText;
	public Text pointsText;
	public Text overText;
	public Text livesText;

	void Start () {
		isActive = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Launch ();
			startText.enabled = false;
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Move(-paddlespeed);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			Stop ();
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Move(paddlespeed);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			Stop ();
		}

		if (lives < 1) {
			GameOver ();
		}
	}

	void Move (int speed){
		paddleRb.velocity = new Vector2 (speed, 0);
	}

	void Stop () {
		paddleRb.velocity = new Vector2 (0, 0);
	}

	void Launch () {
		if (isActive == false && lives > 0) {
			GameObject newBall = Instantiate (ballPrefab) as GameObject;
			Rigidbody2D newBallRb = newBall.GetComponent<Rigidbody2D>();

			newBallRb.velocity = new Vector2 (0, launchspeed);
			isActive = true;
		}
	}

	public void MinusLife(){
		if (lives > 0) {
			lives -= 1;
			livesText.text = "Lives: " + lives;
		}
	}

	void GameOver(){
		overText.text = "Game Over!";
		livesText.enabled = false;
	}

	public void AddPoints(int pointValue){
		points += pointValue;
		pointsText.text = "Points: " + points;
	}
}
