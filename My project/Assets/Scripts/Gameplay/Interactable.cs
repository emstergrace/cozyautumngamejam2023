using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    private string Name;
    private bool hasBeenUsed;
    private float timer;
    private readonly float TIMER_MAX = 1.5f;

    private void Start()
    {
        hasBeenUsed = false;
        timer = 0f;
    }

    private void Update()
    {
        if (timer > TIMER_MAX)
        {
            timer = 0f;
            hasBeenUsed = false;
        }

        if (hasBeenUsed)
        {
            timer += Time.deltaTime;
        }
    }

    public string Use()
    {
        if (!hasBeenUsed)
        {
            hasBeenUsed = true;
            return Name;
        }
        return "";
    }
}
