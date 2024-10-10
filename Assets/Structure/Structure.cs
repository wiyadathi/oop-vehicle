using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Structure : MonoBehaviour
{
    protected string structureName;

    int health;
    public int Health {  get { return health; } set { health = value; } }

    int maxCapacity;
    public int MaxCapacity { get { return maxCapacity; } }

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

    public abstract void Repair();
    public abstract void Upgrade();
    public abstract void GetProductionRate(int workers);


    public void InitializeStructure(string name, int health, int defense, float buildTime, int maxCapacity)
    {
        this.structureName = name;
        this.health = health;
        this.defenseLevel = defense;   
        this.BuildTime = buildTime;
        this.maxCapacity = maxCapacity; 
        
    }
 
    // Method to display the structure's status 

    public void DisplayStructureStatus()
    {

        Debug.Log("Structure: " + structureName + ", Health: " + Health + "%, Defense Level: " 
            + DefenseLevel + ", Build Time: " + BuildTime + " seconds, Max Capacity: " + MaxCapacity);

    }

} 
    
