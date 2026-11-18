using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int health = 50;
    public Slider healthBar;

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthBar.value = health;

        if (health <= 0)
        {
            GameManager.kills++;
            Destroy(gameObject);
        }
    }
}