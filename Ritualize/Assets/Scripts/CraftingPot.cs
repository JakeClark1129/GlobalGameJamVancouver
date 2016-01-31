using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CraftingPot : MonoBehaviour
{
    public GameObject Player;

    public Items m_Ingredients;

    [SerializeField]
    Craftable[] m_craftables;

    public void AddIngredient(Items ingredient)
    {
        m_Ingredients |= ingredient;
    }

    public void Clear()
    {
        m_Ingredients = 0;
    }

    public bool Craft()
    {
        Inventory inventory = Player.GetComponent<Inventory>();
        if (!inventory)
        {
            return false;
        }

        foreach (Craftable craftable in m_craftables)
        {
            if (craftable.m_RequiredItems == m_Ingredients)
            {
                return craftable.Craft(inventory);
            }
        }

        return false;
    }
}
