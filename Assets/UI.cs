using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine; 

public class UI : MonoBehaviour {

    public float timeLeft = 30;
    public Text winText;
    public Text gameOverText;
    public Text timeLeftText;

	// Use this for initialization
	void Start () {
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeLeftText.text = "Time Left: " + (int)timeLeft;
        if (timeLeft < 0)
        {
            gameOver();
        }
    }

    public void win()
    {
        winText.text = "You Win!";
    }

    public void gameOver()
    {
        gameOverText.text = "Game Over!";
    }
}
