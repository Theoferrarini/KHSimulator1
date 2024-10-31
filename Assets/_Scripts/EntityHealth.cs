using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get; private set; }

    public event Action<int> OnHealthChanged;

    public event Action<int> OnMaxHealthChanged;

    public event Action OnGettingHit;

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - damage, 0, _maxHealth);
        OnGettingHit?.Invoke();
        OnHealthChanged?.Invoke(CurrentHealth);
        if (CurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int heal)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + heal, 0, _maxHealth);
        OnHealthChanged?.Invoke(CurrentHealth);
    }

    public void PowerUp(int powerUpValue)
    {
        _maxHealth += powerUpValue;
        OnMaxHealthChanged?.Invoke(_maxHealth);
    }


}