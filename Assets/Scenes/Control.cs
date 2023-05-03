using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;
    
    public void GameOver()
    {
        GameOverScreen.Setup(maxPlatform);
    }
}
