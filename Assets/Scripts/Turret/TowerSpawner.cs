
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TowerSpawner : MonoBehaviour
{
    public static event Action<GameObject> OnSpawnTower;
    [SerializeField] private GameObject towerPrefab;
    private Vector2 minSpawnPosition; 
    private Vector2 maxSpawnPosition;
    [SerializeField] private int towerCost = 50;
    public void SpawnTower()
    {
        if (ScoreManager.instance.Score >= towerCost)
        {
            Vector2 randomPosition = GetRandomPosition();

            GameObject newTower = Instantiate(towerPrefab, randomPosition, Quaternion.identity);

            OnSpawnTower?.Invoke(newTower);

            Debug.Log("Toren gespawned op positie: " + randomPosition);

            ScoreManager.instance.AddScore(-towerCost);
        }
        else 
        {
            Debug.Log("Niet genoeg score om een toren te spawnen!");
        }
    }

    private Vector2 GetRandomPosition()
    {
        float randomX = UnityEngine.Random.Range(minSpawnPosition.x, maxSpawnPosition.x);
        float randomY = UnityEngine.Random.Range(minSpawnPosition.y, maxSpawnPosition.y);
        return new Vector2(randomX, randomY);
    }

    bool IsPositionFree(Vector2 position)
    {
        Collider2D hitCollider = Physics2D.OverlapCircle(position, 0.5f);
        return hitCollider == null;
    }

}
