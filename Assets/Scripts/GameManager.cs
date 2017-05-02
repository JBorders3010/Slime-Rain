﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static float score;
    public static int endCounter;
    //private int highScore;
    private const int END_GAME = 200;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;
        endCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "" + score;
        if (!CheckGame())
        {
            scoreText.text += "  GAME OVER";
            var slime = GameObject.FindGameObjectsWithTag("slime");
            foreach (GameObject s in slime)
            {
                Destroy(s);
            }
        }
	}

    public static bool CheckGame()
    {
        if (endCounter >= END_GAME)
            return false;
        return true;
    }
}
