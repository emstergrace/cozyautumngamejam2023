using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private FrameInput Input;
    private float MovementSpeed = 5f;

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
        if (Input.X > 0)
        {
            characterMovementDirection += Vector3.right;
        } else if (Input.X < 0)
        {
            characterMovementDirection += Vector3.left;
        }

        if (Input.Y > 0) { characterMovementDirection += Vector3.up; }
        else if (Input.Y < 0) { characterMovementDirection += Vector3.down; }

        transform.position += (characterMovementDirection * MovementSpeed * Time.deltaTime);
    }
}