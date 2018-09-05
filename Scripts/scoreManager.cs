using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

    public Text scoreText;
    private int score;
    int newScoreValue;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
        newScoreValue = 10;
	}
	
	private void UpdateScore()
    {

        scoreText.text = "Score: " + score;

    }

    public void addNewScore()
    {

        score += newScoreValue;
        UpdateScore();

    }


}
