using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckZlo : MonoBehaviour
{
    public LayerMask enemyLayerMask;
    public string tagToCheck = "zlo";
    public float radius = 2f;
    public bool enableScript = false;
    public EnemyBullet enemyBulletScript;

    private void Update()
    {
        /*Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, 1 << LayerMask.NameToLayer(tagToCheck));
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag(tagToCheck))
            {
                enableScript = false;
                break;
            }
        }*/

        if (Physics2D.OverlapCircle(transform.position, radius, enemyLayerMask))
        {
            enableScript = true;
        }


        if (!enableScript)
        {
            enemyBulletScript.enabled = true;
        }
        else
        {
            enemyBulletScript.enabled = false;
        }

        //enemyBulletScript.enabled = !enableScript;
    }
}
