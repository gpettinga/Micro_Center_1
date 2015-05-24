using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwapCameras : MonoBehaviour {

	public GameObject fpsCamera;
	public GameObject overHeadCamera;

	public bool fpsActive = true;

	public GameObject[] roofs;

	// Use this for initialization
	void Start () 
	{
		roofs = GameObject.FindGameObjectsWithTag("OverHead");

	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(Input.GetMouseButtonDown(2))
		{
			Swap ();
		}

		if (fpsActive)
		{
			fpsCamera.SetActive(true);
			overHeadCamera.SetActive(false);
			foreach (GameObject obj in roofs)
			{
				obj.SetActive(true);
			}
		}
		else
		{
			fpsCamera.SetActive(false);
			overHeadCamera.SetActive(true);
			foreach (GameObject obj in roofs)
			{
				obj.SetActive(false);
			}
		}



	}

	void Swap()
	{
		fpsActive = !fpsActive;
	}
}
