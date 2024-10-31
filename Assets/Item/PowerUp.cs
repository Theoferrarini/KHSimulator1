using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    [SerializeField] int _powerUpValue = 10;

    public override void Use(PickUpItem pui)
    {
        pui.EntityHealth.PowerUp(_powerUpValue);
        base.Use(pui);
    }
}
