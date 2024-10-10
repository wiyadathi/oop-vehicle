using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Structure
{
    int attackPower;
    
    void Start()
    {
        InitializeStructure("Tower", 80, 30, 60, 100 );
        attackPower = 10;
    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading Tower...");
        DefenseLevel += 10;
        attackPower += 20;
        Debug.Log("Tower upgraded! New Defense Level: " + DefenseLevel + ", New Attack Power: " + attackPower);
    }

    public override int GetProductionRate(int workers)
    {
        return (DefenseLevel * 2) + (workers * attackPower / 100);
    }
}
