using UnityEngine;

public class ForceLauncher : MonoBehaviour
{
    public float force = 500f;
    public Vector3 direction = Vector3.up;

    Rigidbody rb;

    void Awake(){ rb = GetComponent<Rigidbody>(); }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(direction.normalized * force);
        }
    }
}