using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>();

    public Inventory() { SetupInventory(); }
    public void Reset()
    {
        inventory.Clear();
        SetupInventory();
    }

    public void SetupInventory()
    {
        inventory.Add("Milk", 0);
        inventory.Add("Sugar", 0);
        inventory.Add("Flour", 0);
        inventory.Add("Fruit", 0);
        inventory.Add(Ingredients.Eggs, 0);
    }

    public void Add(string key)
    {
        inventory[key] += 1;
    }
}
