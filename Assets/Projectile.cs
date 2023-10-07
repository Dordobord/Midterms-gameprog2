using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform enemy;
    private Vector3 target;

 
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;

        target = new Vector3(enemy.position.x, enemy.position.y, enemy.position.z);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, enemy.position, speed * Time.deltaTime); //Bullet tracks the player
        if (transform.position.x == target.x && transform.position.y == target.y && transform.position.z == target.z)
        {
            DestroyProjectile();
        }
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            DestroyProjectile();
            Destroy(other.gameObject);
        }

    }

    void DestroyProjectile() 
    {
        Destroy(gameObject);
    }
}
