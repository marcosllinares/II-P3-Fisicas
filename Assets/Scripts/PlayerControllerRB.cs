using UnityEngine;

public class PlayerControllerRB : MonoBehaviour
{
    public float moveSpeed = 10f;      // velocidad de movimiento

    Rigidbody rb;

    void Awake(){ rb = GetComponent<Rigidbody>(); }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); // A/D o flechas
        float v = Input.GetAxis("Vertical");   // W/S o flechas
        Vector3 input = new Vector3(h, 0, v);

        // Movimiento básico WASD - usando VelocityChange para respuesta inmediata
        Vector3 movement = input * moveSpeed;
        // rb.AddForce(movement, ForceMode.VelocityChange);
        rb.AddForce(movement, ForceMode.Force);

        // 2 formas de aplicar fuerza:
        // Con ForceMode.Force - gradual, depende de masa
        //rb.AddForce(movement, ForceMode.Force);
        // Si masa = 1kg y movement = (5,0,0), aplica 5N de fuerza
        // El objeto acelera lentamente hacia 5 m/s

        // Con ForceMode.VelocityChange - inmediato, ignora masa  
        //rb.AddForce(movement, ForceMode.VelocityChange);
        // Si movement = (5,0,0), cambia velocidad directamente a 5 m/s
        // Respuesta instantánea sin importar la masa
    }
}