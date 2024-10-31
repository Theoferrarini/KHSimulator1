using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get; private set; }

    public event Action<int> HealthChanged;

    public event Action OnGettingHit;

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - damage, 0, _maxHealth);
        OnGettingHit?.Invoke();
        HealthChanged?.Invoke(CurrentHealth);
        if (CurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int heal)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + heal, 0, _maxHealth);
        HealthChanged?.Invoke(CurrentHealth);
    }


}