using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipShoot : MonoBehaviour
{
    private Rigidbody2D _rb;
    public GameObject bullet;
    public Transform shotPoint;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, shotPoint.position, Quaternion.identity);
        }
    }
}
