using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlien : MonoBehaviour
{
    public float health = 100f; 

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
        Destroy(gameObject);
    }
}
