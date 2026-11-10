using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Slider healthBar;

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthBar.value = health;

        if (health <= 0)
        {
            Debug.Log("Player died");
        }
    }
}