using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _attack;
    [SerializeField] Collider _attackCollider;

    public event Action OnAttack;

    void Start()
    {

    }

    void Update()
    {

    }

    private void Attacking()
    {
        OnAttack?.Invoke();
    }
}
