using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs;
    [SerializeField] float spawnInterval = 2f;

    private float timer;

    void Update()
    {
        if (!GameManager.Instance.IsGameStarted || GameManager.Instance.IsGameOver)
            return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[index], transform.position, Quaternion.identity);
    }
}
