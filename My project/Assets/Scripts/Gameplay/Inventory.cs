using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI milkText, sugarText, flourText, fruitText, eggsText;
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

    public TextMeshProUGUI GetMilkString()
    {
        milkText.text = $"{inventory["Milk"], 0} /2";
        return milkText;
    }

    public TextMeshProUGUI GetSugarString()
    {
        sugarText.text = $"{inventory["Sugar"],0} /1";
        return sugarText;
    }

    public TextMeshProUGUI GetFlourString()
    {
        flourText.text = $"{inventory["Flour"],0} /2";
        return flourText;
    }

    public TextMeshProUGUI GetFruitString()
    {
        fruitText.text = $"{inventory["Fruit"],0} /5";
        return fruitText;
    }

    public TextMeshProUGUI GetEggsString()
    {
        eggsText.text = $"{inventory["Eggs"],0} /3";
        return eggsText;
    }

    public void Add(string key)
    {
        inventory[key] += 1;
    }
}
