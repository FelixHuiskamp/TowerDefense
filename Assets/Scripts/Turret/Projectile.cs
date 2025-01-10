using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float speed = 5f;
    private float lifetime = 2f;
    private float damage = 20f;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyAlien enemy = other.GetComponent<EnemyAlien>();
      if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
      Destroy(gameObject);  
    }
}
