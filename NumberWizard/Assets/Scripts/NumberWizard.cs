using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    //instance variables
    int maxGuess;
    int lowGuess;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
    }
	
    void StartGame() {
        maxGuess = 1000;
        lowGuess = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number in your mind.");
        Debug.Log("Highest number you may pick is: " + maxGuess);
        Debug.Log("Lowest number you may pick is: " + lowGuess);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up arrow = higher  Push down arrow = lower  Hit enter = select");
        maxGuess++;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lowGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
           
        }
        else if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Debug.Log("That's it. Imma genius.");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maxGuess + lowGuess) / 2;
        Debug.Log("The number is higher or lower than " + guess);
    }
}
