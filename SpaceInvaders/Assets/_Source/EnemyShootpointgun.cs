using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootpointgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float minSpawnTime = 3f;
    public float maxSpawnTime = 7f;

    void Start()
    {
        Invoke("SpawnBullet", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Invoke("SpawnBullet", Random.Range(minSpawnTime, maxSpawnTime));
    }
}