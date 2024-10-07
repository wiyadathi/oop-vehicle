using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{

    protected string brand;

    private string model;

    private float fuel;
    public float Fuel
    {
        get { return fuel; }
        set
        {
            if (value < 0)
            {
                fuel = 0;  // Set to minimum value of 0 if input is below 0
            }
            else if (value > 100)
            {
                fuel = 100;  // Set to maximum value of 100 if input is above 100
            }
            else
            {
                fuel = value;  // Set to the provided value if within range
            }
        }
    }

    private int durability;
    public int Durability {get {return durability; } set { durability = value; } }

    public float Speed;

    public abstract void ReFuel(float newFuel);
    public abstract void Repair();

    // Abstract method that returns the resale value of the vehicle
    public abstract int GetResaleValue();

    void Start()
    {
    }

    public void Init(string _brand, string _model, float _fuel, int _durability, float speed)
    {
        brand = _brand;
        model = _model;
        Durability = _durability;
        Fuel = _fuel;
        Speed = speed;
    }

    public void DisplayStatus()
    {
        Debug.Log("Brand: " + brand + ", Model: " + model + ", Fuel Level: " + Fuel + 
                "%, Durability: " + Durability + "%, Speed: " + Speed + "km/h");
    }
}
