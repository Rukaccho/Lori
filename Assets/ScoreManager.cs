using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public EggDelivery eggDelivery;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + eggDelivery.GetScore().ToString();
    }
}