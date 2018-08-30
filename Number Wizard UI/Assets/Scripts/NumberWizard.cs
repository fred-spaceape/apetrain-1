using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

	[SerializeField] int maxGuess;
	[SerializeField] int minGuess;
	[SerializeField] TextMeshProUGUI guessText;

	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame ()
	{
		maxGuess = 1000;
		minGuess = 1;
		guess = Random.Range(minGuess, maxGuess + 1);
		guessText.text = guess.ToString();
	}

	public void OnPressHigher ()
	{
		minGuess = guess;
		NextGuess();
	}

	public void OnPressLower ()
	{
		maxGuess = guess;
		NextGuess();
	}


	// Update is called once per frame
	void Update () {

	}

	void NextGuess ()
	{
		guess = Random.Range(minGuess, maxGuess + 1);
		guessText.text = guess.ToString();
	}

}
