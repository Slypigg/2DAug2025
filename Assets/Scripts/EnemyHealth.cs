using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    public int maxHealth = 10;
    private int currentHealth;

    public GameObject lootPrefab; // Optional: assign a lootable prefab to drop on death
    public GameObject deathEffectPrefab; // Optional: assign a death effect prefab to instantiate on death

    public int CurrentHealth => currentHealth; // Public read-only property

    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (deathEffectPrefab != null)
        {
            Instantiate(deathEffectPrefab, transform.position, Quaternion.identity);
        }
        if (lootPrefab != null)
        {
            Instantiate(lootPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}