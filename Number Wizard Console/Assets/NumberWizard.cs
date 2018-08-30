using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int maxGuess = 1000;
	int minGuess = 1;
	int guess    = 500;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame ()
	{
		maxGuess = 1000;
		minGuess = 1;
		guess    = 500;

		Debug.Log("Pip Pip! Welcome to Number Wizard!");
		Debug.Log("Pick a Number");
		Debug.Log("The highest you can choose is " + maxGuess);
		Debug.Log("The lowest you can choose is " + minGuess);

		Debug.Log("Tell me if your number is higher or lower than " + guess);
		Debug.Log("Push Up for higher");
		Debug.Log("Push Down for lower");
		Debug.Log("Push Enter for correct");

		maxGuess = maxGuess + 1;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        	minGuess = guess;
			NextGuess();
        }

		else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        	maxGuess = guess;
			NextGuess();
        }

		else if (Input.GetKeyDown(KeyCode.Return))
        {
			Debug.Log("I won! Your number was " + guess);
			Debug.Log("Let's Play Again");
			StartGame();
        }
	}

	void NextGuess ()
	{
		guess = (maxGuess + minGuess) / 2;
		Debug.Log("Is your number " + guess + "?");
	}
}
