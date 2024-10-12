using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Structure : MonoBehaviour
{
    protected string structureName;

    int health;
    public int Health {  get { return health; }
        set
        {
            if (value < 0) health = 0;
            else if (value > 100) health = 100;
            else health = value;
        }
    } 

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
        Debug.Log("Structure: " + structureName + ", Health: " + Health + ", Defense Level: " 
            + DefenseLevel + ", Build Time: " + BuildTime + " seconds., Production Rate: " + 
            GetProductionRate());

    }

    public void TakeDamage(int damageAmount)
    {
        Debug.Log(structureName + " is applying " + damageAmount + " damage.");
        Health -= damageAmount;  // Decrease the health by the damage amount
        Debug.Log(structureName + " Health after damage: " + Health);

        if (Health <= 0)
        {
            //Health = 0;
            Debug.Log(structureName + " has been destroyed.");
        }
    }
}

