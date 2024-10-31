using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{

    [SerializeField] int _healValue = 10;

    public override void Use(PickUpItem pui)
    {
        pui.EntityHealth.Heal(_healValue);
        base.Use(pui);
    }

}
