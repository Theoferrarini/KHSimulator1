using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityHealth hit))
        {
            hit.TakeDamage(_damage);
        }
    }
}