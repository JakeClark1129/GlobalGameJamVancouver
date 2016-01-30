using UnityEngine;
using System.Collections;

public class Collectable : Interactable
{
	public Items m_ItemType;

	public override void Interact(GameObject player)
	{
		Inventory inventory = player.GetComponent<Inventory>();
		Items diff = m_ItemType & inventory.inventory;
		if(diff == 0)//if this object is not already in their inventory
		{
			Debug.Log("Object Collected");
			//AND the inventory is not full
			//TODO: add this item to the inventory
			inventory.inventory |= m_ItemType;
			Destroy(this.gameObject);
		}
	}
}
