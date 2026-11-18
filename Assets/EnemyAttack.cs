using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRange = 3.5f;
    public float attackDelay = 1.5f;
    public float hitDelay = 0.5f;
    public int damage = 10;

    Transform player;
    PlayerHealth playerHealth;
    Animator animator;
    float timer;

    void Start()
    {
        player = Camera.main.transform;
        playerHealth = player.GetComponentInParent<PlayerHealth>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        float dist = Vector3.Distance(transform.position, player.position);
        if (dist <= attackRange && timer >= attackDelay)
        {
            timer = 0f;
            animator.SetTrigger("Attack");
            Invoke("DealDamage", hitDelay);
        }
    }

    void DealDamage()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        if (dist <= attackRange)
        {
            playerHealth.TakeDamage(damage);
        }
    }
}