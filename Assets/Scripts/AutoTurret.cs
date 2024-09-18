using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurret : MonoBehaviour
{
    public GameObject proctilePrefab;
    public Transform firePoint; 
    public float fireRate = 1f;
    public float range = 5f;
    public LayerMask targetLayer;

    private float fireCountdown = 0f;

    void Update()
    {
        Collider2D[] targetsInRange = Physics2D.OverlapCircleAll(transform.position, range, targetLayer);

        if (targetsInRange.Length > 0)
        {
            Transform target = targetsInRange[0].transform;
            AimAtTarget(target);
        }

        if (fireCountdown <= 0f)
        { 
            Shoot(); 
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
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
