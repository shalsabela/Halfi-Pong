using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditMenuController : MonoBehaviour
{
    public void OpenLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/halfips/");
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }

}
