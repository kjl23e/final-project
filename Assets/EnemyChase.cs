using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = Camera.main.transform;
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}