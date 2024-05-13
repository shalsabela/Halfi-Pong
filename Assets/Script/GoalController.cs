using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
         
        {
            Debug.Log("Test");
            if (isRight)
            {
                manager.AddLeftScore(1);
            }
            else
            {
                manager.AddRightScore(1);
            }

        }
    }
}
