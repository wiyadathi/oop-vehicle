using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected string itemName;

    private int rarity;
    public int Rarity
    {
        get { return rarity; }
        set
        {
            if (value < 1)
                rarity = 1;
            else if (value > 5)
                rarity = 5;
            else
                rarity = value;
        }
    }

    private float durability;
    public float Durability
    {
        get { return durability; }
        set
        {
            if (value < 0)
                durability = 0;  // Set to minimum value of 0 if input is below 0
            else if (value > 100)
                durability = 100;  // Set to maximum value of 100 if input is above 100
            else
                durability = value;  // Set to the provided value if within range
        }
    }

    public float weight;

    public abstract void Upgrade();

    public abstract int GetItemValue();

    public void InitializeItem(string itemType, float durability, int rarity, float weight)
    {
        this.durability = durability;
        this.rarity = rarity;
        this.itemName = itemType;
        this.weight = weight;
    }

    public void UseItem(int damageAmount)
    {
        Debug.Log($"Using {itemName}...");
        Durability -= damageAmount;
        Debug.Log(itemName + " used. Remaining Durability: " + Durability + "%");

        if (Durability == 0) 
        {
            Debug.Log(itemName + " cannot be used.");
        }
    }

    public void DisplayItemInfo()
    {
        Debug.Log("Item: " + itemName + ", Durability: " + durability + "%, Rarity: " + rarity + 
            ", Weight: " + weight + ", Item Value: " + GetItemValue() );
    }
}
