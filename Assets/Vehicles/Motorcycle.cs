using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : Vehicle
{

    void Start()
    {
        vehicleName = "Motorcycle";
        InitializeVehicle(vehicleName, 50, 5, 50);

        DisplayVehicleStatus();
        Drive(40);
        EnhancePerformance();
        DisplayVehicleStatus();
    }


    public override void EnhancePerformance()
    {
        Debug.Log("Upgrading " + vehicleName + "...");
        SpeedLevel += 20;
        Durability += 2;  // Restore durability after upgrade
        Debug.Log(vehicleName + " upgraded! New Speed Level: " + 
            SpeedLevel + ", Durability + " + Durability + "/10");
    }

    public override int GetTravelRange()
    {
        float baseFuelEfficiency = 10.0f; // Base efficiency in km per liter (you can adjust this value)
        return (int)(FuelCapacity * baseFuelEfficiency * (1 + (Durability / 100.0f)));
    }

}
