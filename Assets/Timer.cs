using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 120f;
    public TextMeshProUGUI TimeText;
    public void Start()
    {
        StartCoroutine(TimeLeft());
    }
  
    IEnumerator TimeLeft()
    {
        do
        {
            DisplayTime();
            yield return new WaitForSeconds(1f);
            timeRemaining--;
        } while (timeRemaining >= 0);
    }
    void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        TimeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
