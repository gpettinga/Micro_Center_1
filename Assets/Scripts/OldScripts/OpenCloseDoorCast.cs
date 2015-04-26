using UnityEngine;
using System.Collections;

public class OpenCloseDoorCast : MonoBehaviour {

	public float rayDistance = 10.0f;
	
	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray lookRay = new Ray (this.transform.position, this.transform.forward*rayDistance);
			
			if(Physics.Raycast(lookRay, out hit, rayDistance))
			{
				if(hit.collider.tag == "OpenDoorButton")
				{
					hit.collider.SendMessageUpwards("OpenDoor");
					Debug.Log ("I hit "+hit.collider.gameObject.name);
					
				}
				else if (hit.collider.tag == "CloseDoorButton")
				{
					hit.collider.SendMessageUpwards("CloseDoor");
					Debug.Log ("I hit "+hit.collider.gameObject.name);
					
				}
			}
		}
	}
}
