using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public List<NewEggDelivery> newEggDelivery = new List<NewEggDelivery>();
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        UpdateScoreText();
    }

    //public void UpdateScoreText()
    //{
    //    scoreText.text = "Score: " + newEggDelivery.GetScore().ToString();
    //}
    public void UpdateScoreText()
    {
        int totalScore = 0;

        foreach (NewEggDelivery eggDelivery in newEggDelivery)
        {
            totalScore += eggDelivery.GetScore();
        }

        scoreText.text = "Score: " + totalScore.ToString();
    }
}