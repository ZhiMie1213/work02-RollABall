using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject winText;

    int score;
    int scoreToWin;

    public Transform coinsHolder;

    void Start()
    {
        winText.SetActive(false);
        scoreToWin = coinsHolder.childCount;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Count: " + score;

        if (score >= scoreToWin)
        {
            winText.SetActive(true);
        }
    }
}
