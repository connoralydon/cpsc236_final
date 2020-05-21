using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void toGame()
    {
        SceneManager.LoadScene("mainScene");
    }

    public void toStats()
    {
        SceneManager.LoadScene("stats");
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void quitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
