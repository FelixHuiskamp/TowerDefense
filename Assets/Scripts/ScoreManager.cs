using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score = 0;
    private TextMeshProUGUI scoreText;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points;

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }

        Debug.Log("Huidige score: " + score);
    }

}
