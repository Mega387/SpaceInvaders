using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public Transform shotpoint;

    private int currentIndex = 5;

    private void Start()
    {
        shotpoint.position = Enemy[4].transform.position;
    }

    private void Update()
    {
        EnemyCounts();
    }

    public void EnemyCounts()
    {
        for (int i = currentIndex - 1; i >= 0; i--)
        {
            if (Enemy[i] == null)
            {
                Enemy.RemoveAt(i);
                currentIndex--;
            }
        }

        if (Enemy.Count > 0)
        {
            shotpoint.position = Enemy[currentIndex - 1].transform.position;
        }

        if (Enemy.Count == 0)
        {
            shotpoint.gameObject.SetActive(false);
        }
    }

}