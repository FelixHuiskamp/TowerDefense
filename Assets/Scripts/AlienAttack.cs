using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AlienAttack : MonoBehaviour
{
    public Transform tower;
    public float speed = 3f;
    public float attackrange = 1f;
    public int damage = 10;
    public float attackcooldown = 1f;

    private float nextAttackTime = 0f;
    private TowerHealth towerHealth;

    void start()
    {
        if (tower != null) 
        { 
            towerHealth = tower.GetComponent<TowerHealth>();
        }
    }

    void Update()
    {
        MoveTowardsTower();

        if (Vector2.Distance(transform.position, tower.position) <= attackrange) 
        {
            AttackTower(); 
        }
    }

    void MoveTowardsTower()
    {
        Vector2 direction = (tower.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, tower.position, speed * Time.deltaTime); 
    }

    void AttackTower()
    {
        if (Time.deltaTime >= nextAttackTime) 
        {
            towerHealth.TakeDamage(damage);
            Debug.Log("Alien valt toren aan!"); 

            nextAttackTime = Time.time + attackcooldown;
        }
    }
}
