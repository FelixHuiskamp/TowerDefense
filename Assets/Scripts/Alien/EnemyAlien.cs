using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlien : MonoBehaviour
{
    [SerializeField] private float health = 100f;
    [SerializeField] private int pointsWorth = 10;
    public delegate void DeathAction();
    public event DeathAction OnDeath;
    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
        {
            Die();
        }
    }

    void Die() 
    {

        if (ScoreManager.instance != null) 
        {
            ScoreManager.instance.AddScore(pointsWorth);
        }

        if (OnDeath != null)
        {
            OnDeath();
        }

        Destroy(gameObject);
    }
}
