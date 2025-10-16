using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float damage = 0f;  // Variable de daño acumulado
    
    public void TakeDamage(float damageAmount)
    {
        damage += damageAmount;
        Debug.Log($"Player recibió {damageAmount} de daño. Daño total: {damage}");
    }
}