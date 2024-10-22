
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletForEnemy : MonoBehaviour
{

    public float speedBullet;
    private Rigidbody2D _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = new Vector2(180, speedBullet);
        _rb.velocity = velocity;
    }
}
