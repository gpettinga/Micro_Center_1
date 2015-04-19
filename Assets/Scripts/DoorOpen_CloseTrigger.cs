using UnityEngine;
using System.Collections;

public class DoorOpen_CloseTrigger : MonoBehaviour 
{

	public Animator ExtdoorAnim;
	public Animator InteriorDoorAnimator;
	public Animator OpenDoorButton;

	public bool doorOpen = false;

	//public GameObject CenterInteriorDoors;
	//public GameObject Extdoor;


	void OnTriggerEnter()
	{
//		InteriorDoorAnimator.SetTrigger("openIntTrigger");
//		ExtdoorAnim.SetTrigger ("openTrigger");
	}

	public void OpenDoor()
	{

			InteriorDoorAnimator.SetTrigger ("DoorOpen");
			ExtdoorAnim.SetTrigger("DoorOpen");
			OpenDoorButton.SetTrigger("HitButtonOpen");
			
			
	}
	public void CloseDoor()
	{
		InteriorDoorAnimator.SetTrigger ("DoorClose");
		ExtdoorAnim.SetTrigger("DoorClose");
		OpenDoorButton.SetTrigger("HitButtonClose");


	}


}
