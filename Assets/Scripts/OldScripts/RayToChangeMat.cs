using UnityEngine;
using System.Collections;

public class RayToChangeMat : MonoBehaviour {

	public float rayDistance = 10.0f;

	RaycastHit hit;

	// Use this for initialization
	void Start () 
	{
	
	//		Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.DrawRay (this.transform.position, this.transform.forward * rayDistance, Color.red);
	
		if (Input.GetMouseButtonDown(0))
		{

			RaycastHit hit;
			Ray lookRay = new Ray (this.transform.position, this.transform.forward*rayDistance);
				
			if(Physics.Raycast(lookRay, out hit, rayDistance))
				{
					if(hit.collider.tag == "changeMaterial")
						{
							hit.collider.SendMessageUpwards("MaterialChangerUp");
							Debug.Log ("I hit "+hit.collider.gameObject.name);
						
						}
				}
		}
		if (Input.GetMouseButtonDown(1))
		{
			RaycastHit hit;
			Ray lookRay = new Ray (this.transform.position, this.transform.forward*rayDistance);
			
			if(Physics.Raycast(lookRay, out hit, rayDistance))
			{
				if(hit.collider.tag == "changeMaterial")
				{
					hit.collider.SendMessageUpwards("MaterialChangerDown");
					Debug.Log ("I hit "+hit.collider.gameObject.name);
					
				}
			}
		}
	}
}
