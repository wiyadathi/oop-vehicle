using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{

    protected string vehicleName;

    private float speedLevel; //how fast the vehicle can move. It can be increased when the vehicle is upgraded.
    public float SpeedLevel
    {
        get { return speedLevel; }
        set //0 - 200 
        {
            if (value < 0)
                speedLevel = 0;  // Set to minimum value of 0 if input is below 0
            else if (value > 200)
                speedLevel = 200;  // Set to maximum value of 100 if input is above 100
            else
                speedLevel = value;  // Set to the provided value if within range
        }
    }

    private int durability; //health/structural integrity of the vehicle. It decreases when the vehicle takes damage.
    public int Durability {get {return durability; }
        set  // 0 - 10
        {
            if (value < 0)
                durability = 0;  // Set to minimum value of 0 if input is below 0
            else if (value > 10)
                durability = 10;  // Set to maximum value of 100 if input is above 100
            else
                durability = value;
        } 
    }

    public float FuelCapacity; //The amount of fuel the vehicle can hold


    public abstract void EnhancePerformance();

    // Abstract method that returns the resale value of the vehicle
    public abstract int GetTravelRange();

    // ////////////////////////
  
    public void InitializeVehicle(string name, float speed, int durability, float fuel)
    {
        this.vehicleName = name;
        this.SpeedLevel = speed;
        this.Durability = durability;
        this.FuelCapacity = fuel;
    }

    public void Drive(float fuelConsumed)
    {
        Debug.Log(vehicleName + " is driving...");

        // Decrease fuel capacity
        FuelCapacity -= fuelConsumed;
        Durability -= 1;

        if (FuelCapacity < 0)
        {
            FuelCapacity = 0;
        }

        Debug.Log(vehicleName + " status after driving: Remaining Fuel: " + FuelCapacity +
            ", Durability: " + Durability + "/10");
    }

    public void DisplayVehicleStatus()
    {
        Debug.Log("Vehicle: " + vehicleName + ", Durability: " + Durability + "/10, Speed Level: "
            + SpeedLevel + ", Fuel Capacity: " + FuelCapacity + " liters, Travel Range: " + GetTravelRange() + " km.");
    }
}
