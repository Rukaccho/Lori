using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public EndEggDelivery endEggDelivery;
    public TextMeshProUGUI scoreText;
    public ScoreValue totalScore;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + totalScore.score.ToString();
    }
}