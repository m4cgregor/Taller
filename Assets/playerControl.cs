using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [Header("mmmmmmmmmmmmmmmmmm salsa")]
    [Header("mmmmmmmmmmmmmmmmmm rico")]
    public Transform playerPosition;
    public Vector3 speed;
    public BoxCollider2D playerCollider;
    public float walkSpeed;
    public float jumpForce;
    public float gravity;
    public float windForce;
    private bool isGround = false;
    //private bool isWall = false; /* "is touching wall?" */

    bool hitGround()
    {
        Debug.DrawRay(transform.position, Vector3.down*2f,Color.red, 1f);
        return Physics.Raycast(transform.position, Vector3.down,  1f);
        
    }

    void Update()
    {
        // Update from keys regardless of what the speed is.
        float movement = Input.GetAxisRaw("Horizontal") * walkSpeed;
        Vector3 moveAmmount = new Vector3(movement * Time.deltaTime, 0, 0);
        playerPosition.position += moveAmmount;


        if (hitGround())
        {
            speed.y = 0f;
        }
        // Gravity and the maybe future wind mechanic
        speed += new Vector3(windForce, -gravity, 0);

        // Respect jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            speed.y = jumpForce;
        }

        // problem: speed WILL go too high and make the player go trough the object
        

        playerPosition.position += (speed * Time.deltaTime);
    }
}