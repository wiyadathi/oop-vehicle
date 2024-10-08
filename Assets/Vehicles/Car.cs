using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    int mileage;
    public// int PassengerCapacity {  get; private set; }
    void Start()
    {
        Init("Toyota", "Corolla",50, 80, 100);
        //PassengerCapacity = 5;

        mileage = 50000;

        DisplayStatus();
        ReFuel(20);
        Repair();
        DisplayStatus();
    }

    public override void ReFuel(float newFuel)
    {
        Debug.Log("Car is refueled: " + newFuel +", Current fuel: " + (Fuel+newFuel));
    }

    public override void Repair()
    {
        Durability = 100;
        Debug.Log("Car is being repaired. Durability: " + Durability);
    }

    public override int GetResaleValue()
    {
        int baseResaleValue = 10000;
        int durabilityBonus = Durability * 10;
        int mileagePenulty = 0;

        if (mileage > 100000) 
        {
            mileagePenulty = 1000;
        }

        return baseResaleValue + durabilityBonus - mileagePenulty; 
    }


}
