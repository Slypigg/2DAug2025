using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventorySlot> slots = new List<InventorySlot>();

    public void AddItem(Item item, int amount = 1)
    {
        // Try to stack
        foreach (var slot in slots)
        {
            if (slot.item == item && slot.quantity < item.maxStack)
            {
                int space = item.maxStack - slot.quantity;
                int toAdd = Mathf.Min(space, amount);
                slot.quantity += toAdd;
                amount -= toAdd;
                if (amount <= 0) return;
            }
        }
        // Add new slot(s) if needed
        while (amount > 0)
        {
            int toAdd = Mathf.Min(item.maxStack, amount);
            slots.Add(new InventorySlot(item, toAdd));
            amount -= toAdd;
        }
    }

    public void RemoveItem(Item item, int amount = 1)
    {
        for (int i = slots.Count - 1; i >= 0 && amount > 0; i--)
        {
            if (slots[i].item == item)
            {
                if (slots[i].quantity > amount)
                {
                    slots[i].quantity -= amount;
                    amount = 0;
                }
                else
                {
                    amount -= slots[i].quantity;
                    slots.RemoveAt(i);
                }
            }
        }
    }
}