using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public bool strenge = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (strenge == true)
        {
            Destroy(gameObject);
            Debug.Log("�� ������");
        }
        else
        {
            strenge = true;
            Debug.Log("����� �� �������");
        }
    }




}
