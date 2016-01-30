using UnityEngine;
using System.Collections;

public abstract class Interactable : MonoBehaviour {

	public GameObject player;

	public abstract void Interact(GameObject player);
}
