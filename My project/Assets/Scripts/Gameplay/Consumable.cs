using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    [SerializeField]
    private string Name;

    public string Consume()
    {
        Destroy(gameObject);
        return Name;
    }
}
