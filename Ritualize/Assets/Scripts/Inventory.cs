using UnityEngine;
using System.Collections;


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
	TinctureOfPain = 1 << 9,
	SoundOfMadness = 1 << 10,
}

public class Inventory : MonoBehaviour 
{
	public Items inventory;
}
