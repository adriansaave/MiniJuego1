using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Asigna aquí el objeto del jugador
    public Vector3 offset = new Vector3(0, 5, -10); // Distancia de la cámara respecto al jugador
    public float followSpeed = 5f; // Velocidad de seguimiento de la cámara
    public float rotationSpeed = 5f; // Velocidad de rotación de la cámara

    void LateUpdate()
    {
        // Calcular la posición deseada de la cámara en base al jugador y el offset
        Vector3 targetPosition = player.position + player.rotation * offset;

        // Suavizar el movimiento de la cámara para que sea más fluido
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Suavizar la rotación de la cámara para que siga la dirección del jugador
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}

