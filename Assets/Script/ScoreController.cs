using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKanan;
    public Text skorKiri;

    public ScoreManager manager;

    private void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
}
