using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeed : MonoBehaviour
{
    public PowerUpManager manager;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;
    public Collider2D ball;
    public int magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hello");
        if (collision == ball)
        {
            paddleLeft.SpeedUp(magnitude);
            paddleRight.SpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
