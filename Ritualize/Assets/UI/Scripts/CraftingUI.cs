
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftingUI : MonoBehaviour
{
    public InventoryUI Inventory;

    public InventorySlot[] Slots;

    private bool HasItem(Items item)
    {
        foreach (InventorySlot slot in Slots)
        {
            if (slot.Item.ID == item)
            {
                return true;
            }
        }
        return false;
    }

    public void HandleDrop(InventorySlot slot)
    {
        if (Inventory == null)
        {
            Debug.LogError("CraftingUI has no Inventory reference");
            return;
        }

        if (Inventory.SelectedItem != null &&
            !HasItem(Inventory.SelectedItem.ID))
        {
            slot.Item = Inventory.SelectedItem;
            Inventory.SelectedItem = null;
        }
    }

    public void HandleClick(InventorySlot slot)
    {
        slot.Item = null;
    }
}
