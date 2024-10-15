using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveDistance = 4f; 
    public float moveSpeed = 2f; 
    private Vector3 startPosition; 
    private bool movingRight = true; 

    void Start()
    {
        
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = transform.position.x;

        if (movingRight)
        {
            newPosition += moveSpeed * Time.deltaTime;
            if (newPosition >= startPosition.x + moveDistance)
            {
                newPosition = startPosition.x + moveDistance;
                movingRight = false;
            }
        }
        else
        {
            newPosition -= moveSpeed * Time.deltaTime;
            if (newPosition <= startPosition.x - moveDistance)
            {
                newPosition = startPosition.x - moveDistance;
                movingRight = true;
            }
        }

        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}