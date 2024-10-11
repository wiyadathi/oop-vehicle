using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Structure
{
    int attackPower;
    
    void Start()
    {
        structureName = "Tower";
        InitializeStructure(structureName, 80, 30, 60, 100 );
        attackPower = 10;

        DisplayStructureStatus();
        TakeDamage(20);
        Upgrade();
        DisplayStructureStatus();
    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading " + structureName + "...");
        DefenseLevel += 10;
        attackPower += 20;
        Health = 100;
        Debug.Log(structureName + " upgraded! New Defense Level: " + DefenseLevel + ", New Attack Power: " + attackPower);
    }

    public override int GetProductionRate()
    {
        int workers = 10;
        return (DefenseLevel * 2) + (workers * attackPower / 100);
    }
}
