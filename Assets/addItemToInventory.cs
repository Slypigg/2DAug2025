using UnityEngine;

public class addItemToInventory : MonoBehaviour
{
    public Item itemToLoot; // Assign the wood Item ScriptableObject in the Inspector
    public int amount = 1;  // Amount to add

    private void OnTriggerEnter2D(Collider2D other)
    {
        Inventory playerInventory = other.GetComponent<Inventory>();
        if (playerInventory != null && itemToLoot != null)
        {
            playerInventory.AddItem(itemToLoot, amount);
            Destroy(gameObject); // Remove the wood from the scene after looting
        }
    }
}
    