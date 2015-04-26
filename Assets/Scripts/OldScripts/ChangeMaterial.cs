using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeMaterial : MonoBehaviour {

	public Material[] materialArray;

	public int matNumber;

	// Use this for initialization
	void Start () 
	{
		gameObject.GetComponent<Renderer>().material = materialArray [0];
	}
	public void MaterialChangerUp()
	{
		matNumber += 1;
	}
	public void MaterialChangerDown()
	{
		matNumber -= 1;
	}
	// Update is called once per frame
	void Update () 
	{
		
//		if (Input.GetMouseButtonDown(0))
//		{
//			matNumber +=1;
//		}
//		if (Input.GetMouseButtonDown (1))
//		{
//			matNumber -= 1;
//		}


		if(matNumber == 1)
		{
			gameObject.GetComponent<Renderer>().material = materialArray[1];
		}
		
		else if (matNumber == 2)
		{
			gameObject.GetComponent<Renderer>().material = materialArray[2];
		}
		else if (matNumber == 3)
		{
			gameObject.GetComponent<Renderer>().material = materialArray[3];
		}
		
//		else if (matNumber == 4)
//		{
//			gameObject.GetComponent<Renderer>().material = materialArray[4];
//		}
		else if (matNumber == 0)
		{
			gameObject.GetComponent<Renderer>().material = materialArray[0];
		}
		if (matNumber >= materialArray.Length)
						matNumber = 0;
		if (matNumber < 0)
						matNumber = materialArray.Length -1;
	}
		
}
