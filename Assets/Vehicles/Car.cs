using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    int horsepower;
    void Start()
    {
        vehicleName = "Car";
        InitializeVehicle(vehicleName, 90, 7, 100);
        horsepower = 150;

        DisplayVehicleStatus();
        Debug.Log("Horsepower: " + horsepower);
        Drive(50);
        EnhancePerformance();
        DisplayVehicleStatus();
    }

    public override void EnhancePerformance()
    {
        Debug.Log("Upgrading " + vehicleName + "...");
        SpeedLevel += 30;
        horsepower += 5;  // Restore durability after upgrade
        Debug.Log(vehicleName + " upgraded! New Speed Level: " + SpeedLevel + 
            ", Horsepower + " + horsepower);
    }

    public override int GetTravelRange()
    {
        float baseFuelEfficiency = 15.0f;  // Base efficiency in km per liter
        return (int)(FuelCapacity * (baseFuelEfficiency - horsepower * 2));
    }


}
