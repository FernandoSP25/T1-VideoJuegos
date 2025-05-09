using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; // Referencia al jugador
    [SerializeField] private float smoothing = 5f; // Suavizado de la cámara

    private Vector3 offset;

    void Start()
    {
        if (playerTransform == null)
        {
            GameObject ninjaObj = GameObject.FindWithTag("Player");
            if (ninjaObj != null)
            {
                playerTransform = ninjaObj.transform;
                offset = transform.position - playerTransform.position;
            }
        }
    }


    void LateUpdate()
    {
        if (playerTransform != null)
        {
            // Seguimiento solo en el eje X
            Vector3 targetPosition = new Vector3(playerTransform.position.x + offset.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
        }
    }
}
