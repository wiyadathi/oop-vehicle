using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : Vehicle
{
    void Start()
    {
        Init("Honda", "CR100", 70, 70, 70);

        DisplayStatus();
        ReFuel(20);
        Repair();
        DisplayStatus();
    }

    // Update is called once per frame
    public override void ReFuel(float newFuel)
    {
        Debug.Log("Motorcycle is refueled: " + newFuel + ", Current fuel: " + (Fuel + newFuel));
    }

    public override void Repair()
    {
        Durability = 100;
        Debug.Log("Motorcycle is repaired. Durability: " + Durability);
    }
}
