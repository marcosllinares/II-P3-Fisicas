using UnityEngine;

public class CollisionReporter : MonoBehaviour
{
    Renderer rend;

    void Awake(){
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision c)
    {
        // Solo cambiar color si colisiona con el player
        if (c.collider.GetComponent<PlayerControllerRB>() != null)
        {
            Debug.Log($"{name} colisionó con: {c.collider.name}");
            if (rend != null) rend.material.color = RandomColor();
        }
    }

    Color RandomColor() => new Color(Random.value, Random.value, Random.value);
}
