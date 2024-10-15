using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    public Vector3 teleportPosition; 

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("player"))
        {
            other.transform.position = teleportPosition;
        }
    }
}