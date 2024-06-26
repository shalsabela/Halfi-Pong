using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D rig;

    public Vector2 resetPosition;

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
       
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;

    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

}
