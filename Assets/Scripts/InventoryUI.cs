using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Text inventoryText; // Assign a UI Text element in the Inspector

    void Update()
    {
        if (inventory == null || inventoryText == null)
            return;

        StringBuilder sb = new StringBuilder();
        foreach (var slot in inventory.slots)
        {
            if (slot.item != null)
                sb.AppendLine($"{slot.item.itemName} x{slot.quantity}");
        }
        inventoryText.text = sb.ToString();
    }
}