using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    [SerializeField] int _moneyValue = 10;

    public override void Use(PickUpItem pui)
    {
        pui.EntityGold.AddGold(_moneyValue);
        base.Use(pui);
    }
}
