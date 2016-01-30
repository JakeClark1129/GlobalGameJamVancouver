using UnityEngine;
using System.Collections;

public class PostProcess : MonoBehaviour 
{

	private MeshRenderer meshRenderer;
	// Use this for initialization
	void Start () 
	{
		meshRenderer = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void ToggleOutline()
	{
		
	}
}
