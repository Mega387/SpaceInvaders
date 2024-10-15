
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{

    public float speedBullet = 1f;


    void Start()
    {
        if (gameObject.CompareTag("Bullet"))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speedBullet);
        }
    }

    void Update()
    {
        
    }
}
