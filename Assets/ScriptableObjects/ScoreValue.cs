using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreValue : ScriptableObject
{
    public int score = 0;

    public void ResetScore()
    {
        score = 0;
    }
}
