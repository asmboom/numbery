using UnityEngine;
using System.Collections;

public class Numbery : MonoBehaviour {

	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up")) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown ("down")) {
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown ("return")) {
			print ("I won!");
			// Uncomment line below if you want a game start again
			//StartGame();
		}
	
	}

	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		print ("========= Welcome =========");
		print ("Hello World! This is numbery");
		print ("Pick a number in your head and don't tell me the number");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower and Enter for equal!");
	}

	void NextGuess(){
		guess = (min + max) / 2;
		print ("Higher or lower than " + guess + "?");
	}
}
