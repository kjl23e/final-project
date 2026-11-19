using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Slider healthBar;

    bool dead;

    public void TakeDamage(int amount)
    {
        if (dead) return;

        health -= amount;
        healthBar.value = health;

        if (health <= 0)
        {
            dead = true;
            Debug.Log("Player died");
            Invoke("Restart", 3f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}