
using UnityEngine;

public enum Items
{
    //Collectibles
    Herb = 1,
    Flower = 1 << 1,
    Root = 1 << 2,
    Charcoal = 1 << 3,
    Jar = 1 << 4,
    Stick = 1 << 5,
    Rock = 1 << 6,

	//Craftibles
	ElixerOfLight = 1 << 7,
	SoulSnatcher = 1 << 8,
	TinctureOfPain = 1 << 9,
	SoundOfMadness = 1 << 10,
}

public class Inventory : MonoBehaviour 
{
    public Items inventory;

    public int PlayerInventoryLimit = 5;

    public GameObject[] Listeners;
    public InventoryItem[] ItemData;

    public bool HasItem(Items item)
    {
        return (item & inventory) != 0;
    }

    public bool IsFull()
    {
        return SparseBitcount((int) inventory) >= PlayerInventoryLimit;
    }

    public void AddItem(Items item)
    {
        inventory |= item;

        foreach (GameObject listener in Listeners)
        {
            listener.SendMessage("HandleInventoryUpdated", this);
        }
    }

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

    // http://www.dotnetperls.com/bitcount
    private static int SparseBitcount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count++;
            n &= (n - 1);
        }
        return count;
    }
}
