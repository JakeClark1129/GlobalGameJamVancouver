
using UnityEngine;

public class CraftingUI : MonoBehaviour
{
    public InventoryUI Inventory;

    public void HandleDrop(InventorySlot slot)
    {
        if (Inventory == null)
        {
            Debug.LogError("CraftingUI has no Inventory reference");
            return;
        }

        slot.Item = Inventory.SelectedItem;
    }
}
