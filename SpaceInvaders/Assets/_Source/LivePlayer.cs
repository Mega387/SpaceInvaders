using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivePlayer : MonoBehaviour
{
    [SerializeField]
    private int lives = 3;
    [SerializeField]
    private TextMeshProUGUI livetext;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            lives--;
            Debug.Log("Осталось жизней: " + lives);
            livetext.text = lives.ToString();

            if (lives <= 0)
            {
                Debug.Log("Игрок уничтожен!");
                Destroy(gameObject);
            }
        }
    }
    private void Start()
    {
        livetext.text = lives.ToString();
    }
}