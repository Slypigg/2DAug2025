using UnityEngine;

public class PlayerLooting : MonoBehaviour
{
    private LootableObject nearbyLoot;

    void Update()
    {
        if (nearbyLoot != null && Input.GetKeyDown(KeyCode.E))
        {
            Inventory inventory = GetComponent<Inventory>();
            nearbyLoot.Loot(inventory);
            nearbyLoot = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        nearbyLoot = other.GetComponent<LootableObject>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<LootableObject>() == nearbyLoot)
        {
            nearbyLoot = null;
        }
    }
}