using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;

    private Text scoreText;
    private int score;

	// Use this for initialization
	void Awake () {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

        if (instance == null)
            instance = this;
	}

    public void SetScore()
    {
        score++;
        scoreText.text = "" + score;
    }
}
