using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AlienAttack : MonoBehaviour
{
    [HideInInspector]
    private List<GameObject> towers = new List<GameObject>();
    public List<GameObject> Towers
    {
        get {  return towers; }

        set { towers = value; }
    }

    private GameObject currentTower;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float attackrange = 1f;
    [SerializeField] private int damage = 10;
    [SerializeField] private float attackcooldown = 1f;

    private float nextAttackTime = 0f;
    private TowerHealth towerHealth;

    void Start()
    {
        int random = (int)Random.Range(0, towers.Count);
        currentTower = towers[random];
        if (currentTower != null) 
        {
            towerHealth = currentTower.GetComponent<TowerHealth>();
        }
    }

    void Update()
    {
        MoveTowardsTower();

        if (Vector2.Distance(transform.position, currentTower.transform.position) <= attackrange) 
        {
            AttackTower(); 
        }
    }

    void MoveTowardsTower()
    {
        Vector2 direction = (currentTower.transform.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, currentTower.transform.position, speed * Time.deltaTime); 

        //Als de afstand kleiner is dan 0.5 moet de alien naar een andere toren kunnen gaan
    }

    void AttackTower()
    {
        if (Time.deltaTime >= nextAttackTime) 
        {
            Debug.Log("Alien valt toren aan!");
            Debug.Log("Schade toegebracht aan toren:" + damage);
            Debug.Log(towerHealth.name);

            if (towerHealth != null)
            {
                towerHealth.TakeDamage(damage);
            }
            


            nextAttackTime = Time.time + attackcooldown;
        }
    }
}
