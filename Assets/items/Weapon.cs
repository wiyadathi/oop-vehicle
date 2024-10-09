using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    int attackPower;

    // Start is called before the first frame update
    void Start()
    {
        InitializeItem(80, 4, "Sword", 2.5f);
        attackPower = 120;

        DisplayItemInfo();
        Use();
        Upgrade();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
