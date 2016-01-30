using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{

	public float MouseSensitivityX;
	public float MouseSensitivityY;

	private CharacterController controller;
	private Transform charTransform;
	private Camera charCam;
	private  Outliner outliner;
	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController> ();
		charTransform = GetComponent<Transform> ();
		charCam = GetComponentInChildren<Camera> ();
		outliner = GetComponent<Outliner> ();
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

		if (Input.GetKey (KeyCode.E)) 
		{
			outliner.Interact(); 
		}

		float rotX = Input.GetAxis ("Mouse Y") * Time.deltaTime*100 * MouseSensitivityX;
		float rotY = Input.GetAxis ("Mouse X") * Time.deltaTime*100 * MouseSensitivityX;
		charCam.transform.Rotate(new Vector3 (-rotX, 0, 0));
		charTransform.transform.Rotate (new Vector3 (0, rotY, 0));

	}
}
