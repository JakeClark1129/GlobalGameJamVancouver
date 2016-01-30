using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CraftingPot : MonoBehaviour
{
	Items m_Ingredients;

	[SerializeField]
	Craftable[] m_craftables;
	void AddIngredient(Items ingredient)
	{
		m_Ingredients |= ingredient;
	}

	void Craft(GameObject player)
	{
		foreach( Craftable craftable in m_craftables)
		{
			if(craftable.m_RequiredItems == m_Ingredients)
			{
				Items inventory = player.GetComponent<Inventory>().inventory; 
				craftable.Craft(inventory);
			}
		}
	}
}
