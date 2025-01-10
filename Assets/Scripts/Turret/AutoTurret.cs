using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AutoTurret : MonoBehaviour
{
    [SerializeField] private GameObject proctilePrefab;
    [SerializeField] private Transform firePoint; 
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private float range = 5f;
    [SerializeField] private LayerMask alienLayer;

    private float fireCountdown = 0f;

    void Update()
    {
        Collider2D[] targetsInRange = Physics2D.OverlapCircleAll(transform.position, range, alienLayer);

        foreach (Collider2D target in targetsInRange)
        {
            
            if (target.CompareTag("Alien"))
            {
                AimAtTarget(target.transform);

                if (fireCountdown <= 0f)
                {
                    Shoot();
                    fireCountdown = 1f / fireRate; 
                }

                fireCountdown -= Time.deltaTime;
                break; 
            }

        }

        if (targetsInRange.Length > 0)
        {
            Transform target = targetsInRange[0].transform;
            AimAtTarget(target);
        }
    }

    void AimAtTarget(Transform target)
    {
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Shoot()
    {
        Instantiate(proctilePrefab, firePoint.position, firePoint.rotation);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red; 
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
