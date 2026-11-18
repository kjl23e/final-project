using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int kills;
    public TMP_Text killText;
    int totalEnemies;

    void Start()
    {
        kills = 0;

        EnemySpawner[] spawners = FindObjectsByType<EnemySpawner>(FindObjectsSortMode.None);
        foreach (EnemySpawner s in spawners)
        {
            totalEnemies += s.maxEnemies;
        }

        Debug.Log("Enemies to kill: " + totalEnemies);
    }

    void Update()
    {
        killText.text = "Kills: " + kills + " / " + totalEnemies;

        if (totalEnemies > 0 && kills >= totalEnemies)
        {
            killText.text = "You win! Map cleared";
            enabled = false;
        }
    }
}