using UnityEngine;
using System.Collections;

public class SwitchLayoutScenes : MonoBehaviour 
{

	public void LayoutScene1()
	{
		Application.LoadLevel(0);
	}
	public void LayoutScene2()
	{
		Application.LoadLevel(1);
	}
	public void LayoutScene3()
	{
		Application.LoadLevel(2);
	}

}
