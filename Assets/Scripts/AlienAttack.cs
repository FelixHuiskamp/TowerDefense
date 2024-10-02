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

    void Start()
    {
        if (tower != null) 
        {
            Debug.Log("test");
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
            Debug.Log(towerHealth.name);
            towerHealth.TakeDamage(damage);
            Debug.Log("Alien valt toren aan!");
            Debug.Log("Schade toegebracht aan toren:" + damage);

            nextAttackTime = Time.time + attackcooldown;
        }
    }
}
