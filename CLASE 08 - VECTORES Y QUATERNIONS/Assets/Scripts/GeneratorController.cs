using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnInterval = 2f;
    [SerializeField] float spawnDelay = 2f;
    void Start()
    {
        //SpawnEnemy();
        InvokeRepeating("SpawnEnemy",spawnDelay,spawnInterval);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform);
    }
}
