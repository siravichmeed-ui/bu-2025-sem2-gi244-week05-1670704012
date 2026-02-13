using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogPrefab;
    public GameObject[] animalPrefab;
    // Update is called once per frame
    private int animalIndex;
    public float spawnRangeX = 15;
    private void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), 2f, 4f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SpawnAnimal();
            }

        }
    }
    void SpawnAnimal()
    {
        animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), transform.position.y, transform.position.z);
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
}
