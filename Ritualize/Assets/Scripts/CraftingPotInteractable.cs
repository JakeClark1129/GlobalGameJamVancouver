using UnityEngine;
using System.Collections;

public class CraftingPotInteractable : Interactable {

	public Canvas CraftingUI;
	public override void Interact(GameObject player)
	{
		CraftingUI.enabled = true;
	}
}
