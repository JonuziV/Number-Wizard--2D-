using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
     public int max = 1000;
     public int min = 1;
     public int guess = 500;
    void Start()
    {
        StartGame();  
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number between 1 & 1000!");
        Debug.Log("Highest number you can pick is " + max);
        Debug.Log("Lowest number you can pick is " + min);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;

    }
    // Update is called once per frame
    void Update()
    {
        CheckKeyPressed();
    }

    void CheckKeyPressed()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The guess was correct!");
            StartGame();
        }

        void NextGuess(){
            guess = (max + min) / 2;
            Debug.Log("Is the number higher or lower than " + guess + "?");
        }
    }
}
