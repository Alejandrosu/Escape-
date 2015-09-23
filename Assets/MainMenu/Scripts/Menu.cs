//Main Menu
//Attached to main camera

using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public Texture backgroundTexture;
	public Texture startButton;
	public Texture exitButton;
	public GUISkin guiSkin;

	void OnGUI(){

		//El GUISkin (Todavia no funciona completamente)
		GUI.skin = guiSkin;

		//Muestra el background
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		//Los botones del Main Menu
		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .5f, Screen.width * .5f, Screen.height * .1f),startButton, "")) 
		{
			Application.LoadLevel("Level1");
		}
		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .75f, Screen.width * .5f, Screen.height * .1f),exitButton, "")) 
		{
			Application.Quit();
		}
	}
}
