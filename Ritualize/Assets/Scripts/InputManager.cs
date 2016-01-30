using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{

	public float MouseSensitivityX;
	public float MouseSensitivityY;
	public float jumpSpeed;
	public float moveSpeed;

	private CharacterController controller;
	private Transform charTransform;
	private Camera charCam;
	private  Outliner outliner;
	//private Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController> ();
		charTransform = GetComponent<Transform> ();
		charCam = GetComponentInChildren<Camera> ();
		outliner = GetComponent<Outliner> ();
		//rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 movement = new Vector3();
		movement *= 0;


		movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		movement = transform.TransformDirection(movement);
		movement *= moveSpeed;
		if (Input.GetButton("Jump"))
			movement.y = jumpSpeed;
		

		movement += Physics.gravity * Time.deltaTime * 10;
		controller.Move(movement * Time.deltaTime);

		if (Input.GetKey (KeyCode.E)) 
		{
			outliner.Interact(); 
		}

		//rb.MovePosition (movement);
		float rotX = Input.GetAxis ("Mouse Y") * Time.deltaTime*100 * MouseSensitivityX;
		float rotY = Input.GetAxis ("Mouse X") * Time.deltaTime*100 * MouseSensitivityX;
		charCam.transform.Rotate(new Vector3 (-rotX, 0, 0));
		charTransform.transform.Rotate (new Vector3 (0, rotY, 0));

	}
}
