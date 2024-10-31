using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{

    [SerializeField] int _gold = 0;

    public event Action<int> GoldChanged;

    void Start()
    {
        GoldChanged?.Invoke(_gold);
    }

    public void AddGold(int amount)
    {
        _gold += amount;
        GoldChanged?.Invoke(_gold);
    }

}
