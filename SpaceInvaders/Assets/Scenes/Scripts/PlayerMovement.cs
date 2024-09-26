using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (gameObject.CompareTag("Player"))
        {
            float moveHorizontal = Input.GetAxis("Horizontal");

            Vector2 movement = new Vector2(moveHorizontal * moveSpeed * Time.deltaTime, 0);
            transform.Translate(movement);
        }
    }
}

