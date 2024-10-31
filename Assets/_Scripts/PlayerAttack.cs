using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _attack;
    [SerializeField] GameObject _attackZone;

    public event Action OnAttack;

    private void Start()
    {
        _attack.action.performed += Attacking;
    }

    private void Attacking(InputAction.CallbackContext obj)
    {
        OnAttack?.Invoke();
        StartCoroutine(Attack());
        IEnumerator Attack()
        {
            _attackZone.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            _attackZone.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        _attack.action.performed -= Attacking;
    }
}