using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : Vehicle
{
    void Start()
    {
        Init("Harley Davidson", "Iron 883", 50, 50, 100);

        DisplayStatus();
        ReFuel(20);
        Repair();
        DisplayStatus();
    }

    // Update is called once per frame
    public override void ReFuel(float newFuel)
    {
        Fuel += newFuel;
        if (Fuel > 100) Fuel = 100;
        Debug.Log("Motorcycle is refueled: " + newFuel + ", Current fuel: " + Fuel + "%");
    }

    public override void Repair()
    {
        Durability = 100;
        Debug.Log("Motorcycle is fully repaired. Durability: " + Durability + "%");
    }

    public override int GetResaleValue()
    {
        int baseResaleValue = 5000;
      
        return baseResaleValue + (Durability * 5) + (int)(Fuel * 5);
    }

}
