using UnityEngine;
using System.Collections;

public class SimpleCameraMovement : MonoBehaviour {

	public float moveSpeed	;
	private float moveX;
	private float moveY;
	private float moveZ;
	private Vector3 camMover;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		moveX = Input.GetAxis ("Horizontal");
		moveZ= Input.GetAxis ("Vertical");
		moveY = Input.GetAxis("Mouse ScrollWheel");

		camMover = new Vector3(moveX,moveY*10,moveZ) * Time.deltaTime * moveSpeed;

		transform.Translate(camMover);



	}
}
