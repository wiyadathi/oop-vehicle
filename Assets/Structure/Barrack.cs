using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrack : Structure
{
    private int unitCapacity;
    float trainingEfficiency;
    void Start()
    {
        structureName = "Barrack";
        InitializeStructure( structureName, 50, 50, 150,50);
        unitCapacity = 100;
        trainingEfficiency = 1.5f;

        DisplayStructureStatus();
        Upgrade();
        TakeDamage(200);
        DisplayStructureStatus();
    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading " + structureName + "...");
        DefenseLevel += 5;
        unitCapacity += 10;
        Health = 100;
        Debug.Log(structureName + " upgraded! New Defense Level: " + DefenseLevel + 
            ", New Unit Capacity: " + unitCapacity + ", Health: " + Health);
    }

    public override int GetProductionRate()
    {
        return (int)(unitCapacity * (DefenseLevel + trainingEfficiency * 10));
    }

}
