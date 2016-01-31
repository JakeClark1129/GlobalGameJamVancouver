using UnityEngine;
using System.Collections;

public class PostProcess : MonoBehaviour 
{

	private MeshRenderer meshRenderer;
	private bool outlined;
	private Shader mainShader;
	// Use this for initialization
	void Start () 
	{
		Material mat = this.GetComponent<Material>();
		if(mat)
		{
			Debug.Log("mat found");
			mainShader = mat.shader;
		}
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
		//	if(mainShader)
			{
				meshRenderer.material.shader = Shader.Find("Standard");
				meshRenderer.material.SetFloat("_Mode", 1);
				outlined = false;
			}
		} else 
		{
			meshRenderer.material.shader = Shader.Find("Outlined/Silhouetted Bumped Diffuse");
			meshRenderer.material.SetFloat("_Mode", 1);
			meshRenderer.material.SetColor ("_OutlineColor", Color.red);
			//meshRenderer.material.SetFloat ("_Outline", 0.05f);
			outlined = true;
		}

	}
}
