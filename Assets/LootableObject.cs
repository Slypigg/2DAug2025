using UnityEngine;

public class LootableObject : MonoBehaviour
{
    public Item itemData; // Assign the corresponding Item ScriptableObject in the Inspector
    public int amount = 1;

    // Call this method when the player interacts with the object
    public void Loot(Inventory inventory)
    {
        if (itemData != null && inventory != null)
        {
            inventory.AddItem(itemData, amount);
            Destroy(gameObject); // Remove the object from the scene
        }
    }
}