using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    float attackPower;

    void Start()
    {
        InitializeItem("Sword", 80, 4, 2.5f);
        attackPower = 120f;

        DisplayItemInfo();
        Debug.Log("Weapon Attack Power : " + attackPower);
        UseItem(10);
        Upgrade();
        DisplayItemInfo();

    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading weapon...");
        attackPower += 20;
        Durability = 100;  // Reset durability after upgrade
        Debug.Log(itemName + " upgraded! New Attack Power: " + attackPower + 
            ", Durability: " + Durability + "%");
    }

    public override int GetItemValue()
    {
        int baseWeaponValue = 500;
        return baseWeaponValue + (Rarity * 100) + ((int)attackPower * 5);
    }







}
