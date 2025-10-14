using UnityEngine;

public class PlayerControllerRB : MonoBehaviour
{
    public float moveSpeed = 6f;      // velocidad deseada en m/s
    public float accel = 20f;         // aceleración
    public float maxSpeed = 8f;       // límite de velocidad

    Rigidbody rb;

    void Awake(){ rb = GetComponent<Rigidbody>(); }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); // A/D o flechas
        float v = Input.GetAxis("Vertical");   // W/S o flechas
        Vector3 input = new Vector3(h, 0, v);
        if (input.sqrMagnitude > 1f) input.Normalize();

        // Movimiento en plano XZ relativo al mundo (si quieres relativo a cámara, usa su forward/right)
        Vector3 desiredVel = input * moveSpeed;
    Vector3 currentVel = rb.linearVelocity;
    Vector3 velChange = desiredVel - new Vector3(currentVel.x, 0, currentVel.z);

        // No jump or grounded checks: always use full ground control while keeping some airControl effect
        float control = 1f;
        Vector3 accelStep = Vector3.ClampMagnitude(velChange, accel * control * Time.fixedDeltaTime);
        rb.AddForce(accelStep, ForceMode.VelocityChange);

        // Clamp velocidad máxima en plano
        Vector3 planar = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
        if (planar.magnitude > maxSpeed)
        {
            planar = planar.normalized * maxSpeed;
            rb.linearVelocity = new Vector3(planar.x, rb.linearVelocity.y, planar.z);
        }
    }
}