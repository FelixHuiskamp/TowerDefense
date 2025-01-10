using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerHealth : MonoBehaviour
{
    [SerializeField] private int health = 100;



    void Start()
    {
        GameManager.instance.AddTower();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Toren gezondheid:" + health);

        if (health <= 0)
        {
            DestroyTower();
        }
    }

    void DestroyTower()
    {
        Debug.Log("De toren is vernietigd!");
        GameManager.instance.RemoveTower();
        Destroy(gameObject);
    }


}
