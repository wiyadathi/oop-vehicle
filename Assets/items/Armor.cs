using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item
{
    int defenseRating;
    
    // Start is called before the first frame update
    void Start()
    {
        InitializeItem("Steel Chestplate", 100,  3, 7.0f);

        defenseRating = 80;

        DisplayItemInfo();
        Debug.Log("Armor Defense Rating : " + defenseRating);
        UseItem(5);
        Upgrade();

        DisplayItemInfo();

    }

    public override void UseItem(int damageAmount)
    {
        Debug.Log("Equipping armor...");
        Durability -= damageAmount;  // Decrease durability by the specified damage amount
        if (Durability < 0) Durability = 0;
        Debug.Log("Armor equipped. Remaining Durability: " + Durability + "%");
    }

    // Override the Upgrade method
    public override void Upgrade()
    {
        Debug.Log("Upgrading armor...");
        defenseRating += 15;
        Durability = 100;  // Reset durability after upgrade
        Debug.Log("Armor upgraded! New Defense Rating: " + defenseRating + ", Durability: " + Durability + "%");
    }

    public override int GetItemValue()
    {
        int baseArmorValue = 300;
        return baseArmorValue + (Rarity * 150) + (defenseRating * 3);
    }

}
