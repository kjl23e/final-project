using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int health = 50;
    public Slider healthBar;
    public float deathTime = 3f;

    bool dead;

    public void TakeDamage(int amount)
    {
        if (dead) return;

        health -= amount;
        healthBar.value = health;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        dead = true;
        GameManager.kills++;

        GetComponentInChildren<Animator>().SetTrigger("Die");

        GetComponent<EnemyAttack>().enabled = false;
        GetComponent<EnemyChase>().enabled = false;
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Collider>().enabled = false;
        healthBar.gameObject.SetActive(false);

        Destroy(gameObject, deathTime);
    }
}