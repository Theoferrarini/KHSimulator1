using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpItem : MonoBehaviour
{

    [SerializeField] EntityGold _entityGold;
    [SerializeField] EntityHealth _entityHealth;

    public EntityGold EntityGold => _entityGold;
    public EntityHealth EntityHealth => _entityHealth;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Item item))
        {
            item.Use(this);
        }
    }
}