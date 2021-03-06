﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoClick2 : MonoBehaviour {
    public string actionName;
    public static bool instructions;

	public void OnClick()
    {
        if (actionName.CompareTo("Play") == 0 || actionName.CompareTo("Again") == 0)
        {
            GameManager.score = 0;
            GameManager.endCounter = 0;
            ScreenManager.scoretrack.Dispose();
            SceneManager.LoadScene("GameScreen");
        }
        else if (actionName.CompareTo("Scores") == 0)
        {
            ScreenManager.scoretrack.Dispose();
            SceneManager.LoadScene("ScoresScreen");
        }
        else if (actionName.CompareTo("Exit") == 0)
        {
            ScreenManager.scoretrack.Dispose();
            ScreenManager.Exit();
        }
        else if (actionName.CompareTo("Submit") == 0)
        {
            ScreenManager.gameStage = 3;
        }
        else if (actionName.CompareTo("Quit") == 0)
        {
            ScreenManager.scoretrack.Dispose();
            GameManager.score = 0;
            GameManager.endCounter = 0;
            SceneManager.LoadScene("MainScreen");
        }
        else if (actionName.CompareTo("Instructions") == 0)
        {
            instructions = true;
        }
        else if (actionName.CompareTo("Back") == 0)
        {
            instructions = false;
        }
    }
}
