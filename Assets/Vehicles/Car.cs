using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    int passengerCapacity;
    public int PassengerCapacity {  get; private set; }
    void Start()
    {
        Init("Toyota", "Corolla",50, 80, 100);
        PassengerCapacity = 5;

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

  
}
