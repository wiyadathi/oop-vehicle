using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Structure : MonoBehaviour
{
    protected string structureName;

    int health;
    public int Health {  get { return health; } set { health = value; } }

    int defenseLevel;
    public int DefenseLevel { 
        get { return defenseLevel; } 
        set 
        { 
            if (value < 0) defenseLevel = 0;
            else if (value > 50) defenseLevel = 50;
            else defenseLevel = value; 
        } 
    }

    public float BuildTime;

    public abstract void Upgrade();
    public abstract int GetProductionRate();


    public void InitializeStructure(string name, int health, int defense, float buildTime, int maxCapacity)
    {
        this.structureName = name;
        this.health = health;
        this.defenseLevel = defense;   
        this.BuildTime = buildTime;
    }
 
    public void DisplayStructureStatus()
    {
        Debug.Log("Structure: " + structureName + ", Health: " + Health + "%, Defense Level: " 
            + DefenseLevel + ", Build Time: " + BuildTime + " seconds., Production Rate: " + 
            GetProductionRate());

    }

    public void TakeDamage(int damageAmount)
    {
        Debug.Log(structureName + " is taking " + damageAmount + " damage.");
        Health -= damageAmount;  // Decrease the health by the damage amount
        if (Health <= 0)
        {
            Health = 0;
            Debug.Log(structureName + " has been destroyed.");
        }

        Debug.Log(structureName + " Health after damage: " + Health + "%");
    }
}

