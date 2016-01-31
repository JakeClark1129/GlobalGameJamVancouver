using UnityEngine;
using System.Collections;

public class Outliner : MonoBehaviour
{
	private Camera charCam;

	private GameObject targetObject;
	private GameObject charRef;
	// Use this for initialization
	void Start () 
	{
		charCam = GetComponentInChildren<Camera> ();
		charRef = transform.gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 from = charCam.transform.position;
		Vector3 to = charCam.transform.forward;
		RaycastHit hit = new RaycastHit();
		LayerMask mask = 1<<LayerMask.NameToLayer ("Interactable");
		bool hits = Physics.Raycast (from, to,out hit ,400, mask);

		if (hits) 
		{
			GameObject tempObj = hit.transform.gameObject;
			if (tempObj != targetObject) 
			{
				if (targetObject)
				{
					targetObject.GetComponentInChildren<PostProcess>().ToggleOutline();
				}
				targetObject = tempObj;
				targetObject.GetComponentInChildren<PostProcess>().ToggleOutline();//SendMessage("ToggleOutline");
			}

		}
		else
		{
			if (targetObject) 
			{
				targetObject.GetComponentInChildren<PostProcess>().ToggleOutline(); //targetObject.SendMessage("ToggleOutline");
				targetObject = null;
			}
		
		}
	}

	public void Interact()
	{
		if (targetObject) 
		{
			Debug.Log("Target Object: " + targetObject);
			targetObject.GetComponent<Interactable>().Interact(charRef);
		}
	}
}
