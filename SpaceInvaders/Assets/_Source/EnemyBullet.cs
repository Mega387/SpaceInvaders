using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    public GameObject bullet;
    public Transform shotPoint;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("RandomDelay", 1f, 10f);
    }

    void Update()
    {
        RandomDelay();
    }
    private void RandomDelay()
    {
        float randomTime = Random.Range(2f, 30f);

        Invoke("DoAction", randomTime);
    }
    private void DoAction()
    {
        Debug.Log("Сработало!");
        Instantiate(bullet, shotPoint.position, Quaternion.identity);
        CancelInvoke();
    }
}