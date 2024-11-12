using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 100f; // Fuerza de empuje hacia adelante y hacia atr�s
    public float rotationSpeed = 100f; // Velocidad de rotaci�n

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtener entradas de usuario
        float moveInput = Input.GetAxis("Vertical"); // Adelante/atr�s (W/S o flechas)
        float turnInput = Input.GetAxis("Horizontal"); // Giro (A/D o flechas)

        // Mover hacia adelante y hacia atr�s en el eje global Z
        Vector3 globalForwardMovement = Vector3.forward * moveInput * speed * Time.deltaTime;
        rb.AddForce(globalForwardMovement, ForceMode.Force);





        // Aplicar torsi�n para girar en base al eje local Y
        if (turnInput != 0)
        {
            rb.AddTorque(transform.up * turnInput * rotationSpeed);
        }
    }
}
