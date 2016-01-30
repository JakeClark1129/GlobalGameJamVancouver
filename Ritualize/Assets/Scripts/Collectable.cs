using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour 
{
	public Items m_ItemType;

	public void Interact(GameObject player)
	{
		Items inventory = player.GetComponent<Inventory>().inventory;
		Items diff = m_ItemType & inventory;
		if(diff == 0)//if this object is not already in their inventory
		{
			//inventory |= m_ItemType;
			//GameObject.Destroy(this);
		}
	}
}
