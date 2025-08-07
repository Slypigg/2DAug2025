using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public int damage = 1;
    public GameObject attackEffectPrefab; // Assign in Inspector

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            IDamageable damageable = other.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(damage);

                // Optional: spawn effect at target position
                if (attackEffectPrefab != null)
                {
                    Instantiate(attackEffectPrefab, other.transform.position, Quaternion.identity);
                }
            }
        }
    }
}