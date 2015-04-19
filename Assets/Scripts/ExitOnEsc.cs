using UnityEngine;
using System.Collections;

public class ExitOnEsc : MonoBehaviour {

	public GameObject UiPanelToOPen;
	public GameObject UiPanelToClose;

	public void exitApplication()
	{
		Application.Quit();
	}

	public void openExitGui()
	{
		UiPanelToOPen.SetActive(true);
		UiPanelToClose.SetActive(false);
		Cursor.visible = true;
	}

	public void closeGUI()
	{
		UiPanelToOPen.SetActive(false);
		UiPanelToClose.SetActive(true);
		Cursor.visible = false;
	}
}
