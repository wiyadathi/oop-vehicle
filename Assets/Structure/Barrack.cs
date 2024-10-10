using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrack : Structure
{
    private int unitCapacity;
    float trainingEfficiency;
    void Start()
    {
        InitializeStructure("Barrack", 90, 50, 150,50);
        unitCapacity = 100;
        trainingEfficiency = 1.5f;
    }

    public override void Upgrade()
    {
        Debug.Log("Upgrading Barracks...");
        DefenseLevel += 5;
        unitCapacity += 10;
        Debug.Log("Barracks upgraded! New Defense Level: " + 
            DefenseLevel + ", New Unit Capacity: " + unitCapacity);
    }

    public override int GetProductionRate(int workers)
    {
        return (int)(unitCapacity * (DefenseLevel + trainingEfficiency * 10));
    }

}
