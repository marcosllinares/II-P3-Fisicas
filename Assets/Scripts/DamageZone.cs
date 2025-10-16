using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [Header("Configuración de Daño")]
    public float damageAmount = 10f;     // Cantidad de daño por entrada

    void OnTriggerEnter(Collider other)
    {
        // Verificar si es el player
        PlayerControllerRB player = other.GetComponent<PlayerControllerRB>();
        if (player != null)
        {
            // Buscar componente de salud del player
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log($"Player entró en zona de daño - Daño aplicado: {damageAmount}");
            }
        }
    }
}