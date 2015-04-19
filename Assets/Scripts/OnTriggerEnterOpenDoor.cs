using UnityEngine;
using System.Collections;

public class OnTriggerEnterOpenDoor : MonoBehaviour {

	public Animator doorAnimatorEXT;
	public Animator doorAnimatorInt;
	//public GameObject player;

	void OnTriggerEnter(Collider other) 
	{
		doorAnimatorEXT.SetTrigger("DoorOpen");
		doorAnimatorInt.SetTrigger("DoorOpen");
	}

	void OnTriggerExit(Collider other)
	{
		doorAnimatorEXT.SetTrigger("DoorClose");
		doorAnimatorInt.SetTrigger("DoorClose");
	}
}
