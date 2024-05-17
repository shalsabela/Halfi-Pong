using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("Game");

    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Halfi Pradnya Shalsabela");
    }

    public void OpenCredit()
    {
        SceneManager.LoadScene("Credits");
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
