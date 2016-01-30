using UnityEngine;
using System.Collections;




public class Craftable : MonoBehaviour
{
	public Items m_ItemType;

	[SerializeField]
	Items[] m_RequiredItemsList;

	public Items m_RequiredItems { get; private set; }

	public bool Craft(ref Items inventory)
	{
		Items diff = inventory & m_RequiredItems;
		if (diff == m_RequiredItems)
		{
			inventory ^= m_RequiredItems;//remove used items form inventory
			inventory |= m_ItemType;//add crafted item to inventory
			return true; //item is craftable
		}
		return false; //not all mats are owned
	}

	public void Start()
	{
		m_RequiredItems = 0;
		foreach(Items item in m_RequiredItemsList)
		{
			m_RequiredItems |= item;
		}
	}



}
