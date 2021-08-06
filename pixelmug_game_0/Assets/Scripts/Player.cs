using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float moveSpeed = 5.0f;

    private float hor;
    private bool canJump;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if(Input.GetButtonDown("Jump")) canJump = true;

        if(hor != 0) animator.SetBool("moving", true); else animator.SetBool("moving", false);
    }

    void FixedUpdate()
    {
        controller.Move(hor*Time.fixedDeltaTime, false, canJump);
        canJump = false;
    }
}
 