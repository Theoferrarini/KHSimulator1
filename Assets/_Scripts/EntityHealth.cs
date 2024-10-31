using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get; private set; }

    public event Action<int> HealthChanged;

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        HealthChanged?.Invoke(CurrentHealth);
        //if (CurrentHealth <= 0)
        //{
        //    Die();
        //}
    }
}