using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float spawnRange = 50f;
    public float spawnDelay = 5f;
    public int maxEnemies = 5;

    float timer;
    int count;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        if (dist > spawnRange) return;

        timer += Time.deltaTime;
        if (timer >= spawnDelay && count < maxEnemies)
        {
            timer = 0f;
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            count++;
        }
    }
}