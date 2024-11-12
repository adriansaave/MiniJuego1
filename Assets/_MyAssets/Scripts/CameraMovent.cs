using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Asigna aqu� el objeto del jugador
    public Vector3 offset = new Vector3(0, 5, -10); // Distancia de la c�mara respecto al jugador
    public float followSpeed = 5f; // Velocidad de seguimiento de la c�mara
    public float rotationSpeed = 5f; // Velocidad de rotaci�n de la c�mara

    void LateUpdate()
    {
        // Calcular la posici�n deseada de la c�mara en base al jugador y el offset
        Vector3 targetPosition = player.position + player.rotation * offset;

        // Suavizar el movimiento de la c�mara para que sea m�s fluido
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Suavizar la rotaci�n de la c�mara para que siga la direcci�n del jugador
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}

