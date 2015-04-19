using UnityEngine;
using System.Collections;

public class ShowUI : MonoBehaviour 
{


	public GameObject UiPanel;
	public GameObject ExitUiPanel;

	public bool uiActive = false;
	// Use this for initialization
	void Start () 
	{
	
		Cursor.visible = false;
		Screen.fullScreen=!Screen.fullScreen;

	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetKeyDown(KeyCode.Escape)&&!uiActive)
		{
			UiPanel.SetActive(true);

			Cursor.visible = true;
			uiActive = true;
		}
		else if (Input.GetKeyDown(KeyCode.Escape))
		{
			UiPanel.SetActive(false);
			ExitUiPanel.SetActive(false);

			Cursor.visible = false;
			uiActive = false;
		}

	}
}
