using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private FrameInput Input;
    private float MovementSpeed = 5f;
    private Vector3 FacingDirection = Vector3.down;
    private Vector3 MovementDirection = Vector3.zero;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
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
            X = UnityEngine.Input.GetAxisRaw("Horizontal"),
            Interact = UnityEngine.Input.GetKey(KeyCode.E)
        };
    }

    private void MovePlayer()
    {
        var characterMovementDirection = Vector3.zero;
        if (Input.X > 0)
        {
            characterMovementDirection += Vector3.right;
        }
        else if (Input.X < 0)
        {
            characterMovementDirection += Vector3.left;
        }

        if (Input.Y > 0) { characterMovementDirection += Vector3.up; }
        else if (Input.Y < 0) { characterMovementDirection += Vector3.down; }

        if(characterMovementDirection != Vector3.zero) {
            FacingDirection = characterMovementDirection;
        }

        MovementDirection = characterMovementDirection;

        _rb.velocity = MovementDirection * MovementSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}