using UnityEngine;
using System.Collections;

public class PostProcess : MonoBehaviour 
{

	private MeshRenderer meshRenderer;
	private bool outlined;
	// Use this for initialization
	void Start () 
	{
		outlined = false;
		meshRenderer = GetComponent<MeshRenderer> ();
	}

	// Update is called once per frame
	void Update () 
	{
	
	}

	public void ToggleOutline()
	{
		if (outlined) 
		{
			meshRenderer.material.shader = Shader.Find("Diffuse");
			outlined = false;
		} else 
		{
			meshRenderer.material.shader = Shader.Find("Outlined/Silhouetted Bumped Diffuse");
			meshRenderer.material.SetColor ("_OutlineColor", Color.red);
			//meshRenderer.material.SetFloat ("_Outline", 0.05f);
			outlined = true;
		}

	}
}
