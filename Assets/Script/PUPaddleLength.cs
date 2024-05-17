using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleLength : MonoBehaviour
{
    public PowerUpManager manager;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;
    public Collider2D ball;
    public float newLength;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleLeft.Enlarge(newLength);
            paddleRight.Enlarge(newLength);
            manager.RemovePowerUp(gameObject);
        }
    }

}
