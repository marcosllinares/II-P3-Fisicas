using UnityEngine;

public class ColorChangeZone : MonoBehaviour
{
    public Color zoneColor = Color.green;  // Color que se aplicará al player

    void OnTriggerEnter(Collider other)
    {
        // Verificar si es el player
        PlayerControllerRB player = other.GetComponent<PlayerControllerRB>();
        if (player != null)
        {
            // Cambiar color del player
            Renderer playerRenderer = other.GetComponent<Renderer>();
            if (playerRenderer != null)
            {
                // Guardar color original si no existe
                PlayerColorManager colorManager = other.GetComponent<PlayerColorManager>();
                if (colorManager == null)
                {
                    colorManager = other.gameObject.AddComponent<PlayerColorManager>();
                    colorManager.originalColor = playerRenderer.material.color;
                }
                
                playerRenderer.material.color = zoneColor;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verificar si es el player
        PlayerControllerRB player = other.GetComponent<PlayerControllerRB>();
        if (player != null)
        {
            // Restaurar color original del player
            Renderer playerRenderer = other.GetComponent<Renderer>();
            PlayerColorManager colorManager = other.GetComponent<PlayerColorManager>();
            
            if (playerRenderer != null && colorManager != null)
            {
                playerRenderer.material.color = colorManager.originalColor;
            }
        }
    }
}

// Componente auxiliar para guardar el color original del player
public class PlayerColorManager : MonoBehaviour
{
    public Color originalColor;
}