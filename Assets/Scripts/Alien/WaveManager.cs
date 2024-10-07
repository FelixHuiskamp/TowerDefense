using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject enemyPrefab;
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

        spawnWave = false;
        Debug.Log("Wave " + waveNumber + "compleet!"); 

        void spawnEnemy () { }
    }
}
