using UnityEngine;

public class TreeHealth : MonoBehaviour, IDamageable
{
    public int maxHealth = 5;
    private int currentHealth;

    public GameObject lootableWoodPrefab; // Assign your wood prefab with addItemToInventory attached

    void Awake()
    {
        currentHealth = maxHealth;
    }

    // Call this method to damage the tree
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
        if (lootableWoodPrefab != null)
        {
            Instantiate(lootableWoodPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }

}