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
            if (value < 0 || value > 100)
                fuel = 0;
            else fuel = value;
        }
    }

    private int durability;
    public float Durability {get {return durability; } set { fuel = value; } }

    public float Speed;
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
}
