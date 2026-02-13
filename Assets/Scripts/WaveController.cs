using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Transform[] spawnPoint;

    private Wave wave;
    private int spawnedEnemies = 0;
    private float nextSpawnTime = 0;

    public void ChangeWave(Wave wave2)
    {
        wave = wave2;
    }

    public bool IsCompleted()
    {
        return spawnedEnemies >= wave.enemyCount;
    }
    private void Update()
    {
        float t = Time.time;
        if (spawnedEnemies < wave.enemyCount && t > nextSpawnTime)
        {
            Spawn();
            spawnedEnemies++;
            nextSpawnTime = t + wave.spawnInterval;
        }

    }
    void Spawn()
    {
        int enemyIndex = Random.Range(0, wave.enemyPrefabs.Length);
        int pointIndex = Random.Range(0, spawnPoint.Length);

        var prefabs = wave.enemyPrefabs[enemyIndex];
        var point = spawnPoint[pointIndex];

        Instantiate(prefabs, point.position, Quaternion.Euler(0, 180, 0));
    }
}
