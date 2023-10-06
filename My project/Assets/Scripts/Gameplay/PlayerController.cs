using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private FrameInput Input;
    private float MovementSpeed = 5f;
    private Vector3 FacingDirection = Vector3.down;
    private Vector3 MovementDirection = Vector3.zero;

    private Animator animator;
    
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GatherInput();
        MovePlayer();
    }

    private void GatherInput()
    {
        Input = new FrameInput
        {
            Y = UnityEngine.Input.GetAxisRaw("Vertical"),
            X = UnityEngine.Input.GetAxisRaw("Horizontal")
        };
    }

    private void MovePlayer()
    {
        var characterMovementDirection = Vector3.zero;

        if (Input.X != 0 || Input.Y != 0)
        {
            animator.SetFloat("XInput", Input.X);
            animator.SetFloat("YInput", Input.Y);
        }

        if (Input.X > 0)
        {
            characterMovementDirection += Vector3.right;
        }
        else if (Input.X < 0)
        {
            characterMovementDirection += Vector3.left;
        }

        if (Input.Y > 0) 
        {
            characterMovementDirection += Vector3.up; 
        }
        else if (Input.Y < 0) 
        {
            characterMovementDirection += Vector3.down; 
        }

        // animation stuff
        if (Input.Y == 0 && Input.X == 0)
        {
            animator.SetBool("IsWalking", false);
        }
        else
        {
            animator.SetBool("IsWalking", true);
        }

        if (characterMovementDirection != Vector3.zero) {
            FacingDirection = characterMovementDirection;
        }

        MovementDirection = characterMovementDirection.normalized;

        _rb.velocity = MovementDirection * MovementSpeed;
    }
}