using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    float attackPower;

    void Start()
    {
        itemName = "Sword";
        InitializeItem(itemName, 80, 4, 2.5f);
        attackPower = 120f;

        DisplayItemInfo();
        Debug.Log(itemName + " Attack Power : " + attackPower);
        Upgrade();
        UseItem(10);
        DisplayItemInfo();

    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading weapon...");
        attackPower += 20;
        Durability += 10;  // Reset durability after upgrade
        Debug.Log(itemName + " upgraded! New Attack Power: " + attackPower + 
            ", Durability: " + Durability + "%");
    }

    public override int GetItemValue()
    {
        int baseWeaponValue = 500;
        return baseWeaponValue + (Rarity * 100) + ((int)attackPower * 5);
    }







}
