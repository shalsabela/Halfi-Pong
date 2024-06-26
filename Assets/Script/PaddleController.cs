using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {

        //ambil input
        Vector2 movement = GetInput();

     
        //gerakan object pake input
        MoveObject(movement);
    }

    public void SpeedUp(int newSpeed)
    {
        speed = newSpeed;
    }

    public void Enlarge(float newLength)
    {
        transform.localScale = new Vector3(transform.localScale.x, newLength, transform.localScale.z);
    }
    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }

        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;

    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

}
