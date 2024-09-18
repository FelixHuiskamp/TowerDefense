using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5f;
    public float lifetime = 2f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      Destroy(gameObject);  
    }
}
