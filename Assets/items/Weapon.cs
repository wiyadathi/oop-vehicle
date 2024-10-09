using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    float attackPower;

    // Start is called before the first frame update
    void Start()
    {
        InitializeItem("Sword", 80, 4, 2.5f);
        attackPower = 120f;

        DisplayItemInfo();
        Debug.Log("Attack Power : " + attackPower);
        UseItem(10);
        Upgrade();

        DisplayItemInfo();

    }

    public override void UseItem(int damageAmount)
    {
        Debug.Log("Using Weapon...");
        Durability -= damageAmount;
        if (Durability < 0) { Durability = 0; }
        Debug.Log("Weapon used. Remaining Durability: " + Durability + "%");
    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading weapon...");
        attackPower += 20;
        Durability = 100;  // Reset durability after upgrade
        Debug.Log("Weapon upgraded! New Attack Power: " + attackPower + 
            ", Durability: " + Durability + "%");
    }

    public override int GetItemValue()
    {
        int baseWeaponValue = 500;
        return baseWeaponValue + (Rarity * 100) + ((int)attackPower * 5);
    }







}
