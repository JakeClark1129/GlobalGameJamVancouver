
using UnityEngine;

public enum Items
{
    //Collectables
    Herb = 1,
    Flower = 1 << 1,
    Root = 1 << 2,
    Charcoal = 1 << 3,
    Jar = 1 << 4,
    Stick = 1 << 5,
    Rock = 1 << 6,

    //Craftables
    ElixerOfLight = 1 << 7,
    SoulSnatcher = 1 << 8,
}

public class Inventory : MonoBehaviour 
{
    public Items inventory {get; private set;}

    public InventoryItem[] ItemData;

    public InventoryItem GetItemData(Items ID)
    {
        foreach (InventoryItem item in ItemData)
        {
            if (item.ID == ID)
            {
                return item;
            }
        }
        return null;
    }
}
