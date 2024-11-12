using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 100f; // Fuerza de empuje hacia adelante y hacia atrás
    public float rotationSpeed = 100f; // Velocidad de rotación

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtener entradas de usuario
        float moveInput = Input.GetAxis("Vertical"); // Adelante/atrás (W/S o flechas)
        float turnInput = Input.GetAxis("Horizontal"); // Giro (A/D o flechas)

        // Mover hacia adelante y hacia atrás en el eje global Z
        Vector3 globalForwardMovement = Vector3.forward * moveInput * speed * Time.deltaTime;
        rb.AddForce(globalForwardMovement, ForceMode.Force);





        // Aplicar torsión para girar en base al eje local Y
        if (turnInput != 0)
        {
            rb.AddTorque(transform.up * turnInput * rotationSpeed);
        }
    }
}
