using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public int damage = 25;

    void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemy = other.GetComponentInParent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}