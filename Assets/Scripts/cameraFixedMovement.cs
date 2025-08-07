using UnityEngine;

public class cameraFixedMovement : MonoBehaviour
{
    [SerializeField] private Transform player; // Assign your player in the Inspector
    [SerializeField] private Vector3 offset = new Vector3(0, 0, -10); // Default camera offset
    [SerializeField] private float smoothSpeed = 0.125f; // Adjust for more/less smoothing
    [SerializeField] private float lookAheadDistance = 2f; // How far ahead to look in the facing direction

    void LateUpdate()
    {
        if (player != null)
        {
            // Use right vector for 2D facing direction
            Vector3 lookAhead = player.right * lookAheadDistance;
            Vector3 desiredPosition = player.position + offset + lookAhead;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
    