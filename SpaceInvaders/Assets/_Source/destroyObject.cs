using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    Points Points;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("playerbullet"))
        {
            Destroy(gameObject);
            Points.points += 50;
        }
    }

   
}