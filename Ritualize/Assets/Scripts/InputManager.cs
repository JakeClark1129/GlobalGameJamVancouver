using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{

	private CharacterController controller;
	private Transform charTransform;
	private Camera charCam;

	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController> ();
		charTransform = GetComponent<Transform> ();
		charCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey (KeyCode.W)) 
		{
			controller.Move (charTransform.forward); 
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			controller.Move (-charTransform.forward); 
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			controller.Move (charTransform.right); 
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			controller.Move (-charTransform.right); 
		}

		Vector3 mousePos = Input.mousePosition;

	}
}
