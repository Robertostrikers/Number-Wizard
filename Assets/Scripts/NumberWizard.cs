using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
   [SerializeField] int max = 1000; //number must be +1 to avoid 999 cap
   [SerializeField] int min = 1;
   [SerializeField] TextMeshProUGUI guessText;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    //message to show when starting the game and replaying
    void StartGame()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
       
    }

    //This function make a new guess
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        if (guess > 1000)
        {
            guess = 1000;
        }
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    
    public void OnPressLower()
    {
        max = guess -1;
        NextGuess();
    }
}
