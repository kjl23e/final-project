using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRange = 2f;
    public float attackDelay = 1.5f;
    public int damage = 10;

    Transform player;
    PlayerHealth playerHealth;
    float timer;

    void Start()
    {
        player = Camera.main.transform;
        playerHealth = player.GetComponentInParent<PlayerHealth>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        float dist = Vector3.Distance(transform.position, player.position);
        if (dist <= attackRange && timer >= attackDelay)
        {
            timer = 0f;
            playerHealth.TakeDamage(damage);
        }
    }
}