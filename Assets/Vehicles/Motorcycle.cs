using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : Vehicle
{
    bool isSportBike;
    void Start()
    {
        Init("Vespa", "S125", 50, 50, 50);

        isSportBike = true;

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

    public override int GetResaleValue()
    {
        int baseResaleValue = 5000;
        int durabilityBonus = Durability * 2;
        int sportBikeBonus = 0;

        if (isSportBike)
        {
            sportBikeBonus = 2000;
        }

        return baseResaleValue + durabilityBonus + sportBikeBonus;
    }

}
