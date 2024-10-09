using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public float weight;

    protected string itemName;

    private int rarity;
    public int Rarity
    {
        get { return rarity; }
        set
        {
            if (value < 1)
            {
                rarity = 1;
            }
            else if (value > 5)
                rarity = 5;
            else
            {
                rarity = value;
            }
        }
    }

    private int durability;
    public int Durability
    {
        get { return durability; }
        set
        {
            if (value < 0)
            {
                durability = 0;  // Set to minimum value of 0 if input is below 0
            }
            else if (value > 100)
            {
                durability = 100;  // Set to maximum value of 100 if input is above 100
            }
            else
            {
                durability = value;  // Set to the provided value if within range
            }
        }
    }

    public abstract void Use();
    public abstract void Upgrade();

    public abstract int GetItemValue();

    // Constructor for Item class (since MonoBehaviour classes can't have constructors)
    public void InitializeItem(int durability, int rarity, string itemType, float weight)
    {
        this.durability = durability;
        this.rarity = rarity;
        this.itemName = itemType;
        this.weight = weight;
    }

    public void DisplayItemInfo()
    {
        Debug.Log("Item Type: " + itemName + "Durability: " + durability + "%, Rarity: " 
            + rarity + ", Weight: " + weight + ", Item Value: " + GetItemValue() );
    }



}
