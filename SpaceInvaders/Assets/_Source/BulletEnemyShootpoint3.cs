using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyShootpoint3 : MonoBehaviour
{
    public float speed = 6f;
    public LayerMask playerLayer;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if ((playerLayer.value & (1 << other.gameObject.layer)) > 0)
        {
            Debug.Log("Игрок убит!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}