using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("Start.Menu");
    }
}
