using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    int numberOfSeats;
    public// int PassengerCapacity {  get; private set; }
    void Start()
    {
        Init("Toyota", "Corolla",50, 80, 100);
        numberOfSeats = 5;

        DisplayStatus();
        ReFuel(20);
        Repair();
        DisplayStatus();
    }

    public override void ReFuel(float newFuel)
    {
        Fuel += newFuel;
        
        Debug.Log("Car is refueled: " + newFuel +", Current fuel: " + Fuel + "%");
    }

    public override void Repair()
    {
        Durability = 100;
        Debug.Log("Car is fully repaired. Durability: " + Durability + "%");
    }

    public override int GetResaleValue()
    {
        int baseResaleValue = 10000;

        return baseResaleValue + (Durability * 10) + ((int)Fuel * 10) + (numberOfSeats * 10); 
    }


}
