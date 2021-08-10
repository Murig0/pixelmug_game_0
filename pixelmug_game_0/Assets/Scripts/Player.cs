using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICollidable
{
    public CharacterController2D controller;
    private Animator animator;
    private Rigidbody2D rBody;

    public float moveSpeed = 5.0f;
    public Vector2 jumpForce;
    private float hor;
    private bool canJump; //deprecated

    void Start()
    {
        animator = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal") * moveSpeed;

        transform.position += new Vector3(hor * Time.deltaTime, 0, 0);

        if (Input.GetButtonDown("Jump") && canJump)
        {
            rBody.AddForce(jumpForce);
        }

        //Animazioni
        if (hor != 0)
        {
            animator.SetBool("moving", true);
        }
        else 
        { 
            animator.SetBool("moving", false); 
        }
    }

    public void EnterCollidable()
    {
        canJump = true;
    }

    public void ExitCollidable()
    {
        canJump = false;
    }
}
 