using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    [SerializeField]
    private List<GameObject> towers = new List<GameObject>();

    public GameObject tower;
    public Transform[] spawnpoints;
    public int enemiesPerWave = 5;
    public float timeBetweenSpawns = 1f;

    private int enemiesRemaining;
    private int  waveNumber = 0;
    private bool spawningWave = false;
    void Start()
    {
        StartCoroutine(StartWave());
    }

    
    void Update()
    {
        if (!spawningWave && enemiesRemaining <= 0)
        {
            StartCoroutine(StartWave());
        }
    }

    IEnumerator StartWave() 
    { 
        waveNumber++;
        spawningWave = true;
        enemiesRemaining = enemiesPerWave;

        Debug.Log("Wave " + waveNumber + "begonnen!");

        for (int i = 0; i < enemiesRemaining; i++) 
        {
            SpawnEnemy(); 
            yield return new WaitForSeconds(timeBetweenSpawns);
        }

        spawningWave = false;
        Debug.Log("Wave " + waveNumber + "compleet!"); 

        void SpawnEnemy() 
        {
            int spawnIndex = Random.Range(0, spawnpoints.Length);
            Transform spawnPoint = spawnpoints[spawnIndex];

            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            enemy.GetComponent<AlienAttack>().towers = towers; 

            enemy.GetComponent<EnemyAlien>().OnDeath += EnemyDied;
        }

        void EnemyDied()
        {
            enemiesRemaining--;
        }
    }
}
