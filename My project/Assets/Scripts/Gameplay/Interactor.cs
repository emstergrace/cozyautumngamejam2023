using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class Interactor : MonoBehaviour
{
    private Inventory _inventory;
    private GameObject CurrentInteactable;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = new Inventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.E))
        {
            Interact(CurrentInteactable);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Interactable>() != null
            || collision.gameObject.GetComponent<Consumable>() != null)
        {
            CurrentInteactable = collision.gameObject;
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == CurrentInteactable)
        {
            CurrentInteactable = null; 
        }
    }

    private void Interact(GameObject interactable)
    {
        if (interactable != null)
        {
            var consumableComponent = interactable.gameObject.GetComponent<Consumable>();
            var interatableComponent = interactable.gameObject.GetComponent<Interactable>();

            if (consumableComponent != null)
            {
                var item = consumableComponent.Consume();
                _inventory.Add(item);
            }

            if (interatableComponent != null)
            {
                var item = interatableComponent.Use();
                _inventory.Add(item);
            }
        }
    }
}
