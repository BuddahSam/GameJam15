using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public Texture2D backGroundTexture;

	public int buttonWidth=100;
	public int buttonHeight=30;

	public int buttonSpacing=70;

	public int buttonYstart=300;
	string nameText ="";

	public GUISkin skin;

	void OnGUI(){
			
		GUI.skin = skin;

				GUI.DrawTexture (new
		                Rect (0, 0, Screen.width , Screen.height), backGroundTexture);
				nameText = GUI.TextField (new Rect (Screen.width / 2 -
						100.0f, 50.0f, 100.0f, 20.0f), nameText);
		GUI.Label (new Rect (Screen.width / 2 - 250, 50, 100, 50), "Please enter your name");

				int buttonYposition = buttonYstart;

				if (GUI.Button (new Rect (Screen.width / 2 - buttonWidth / 2,
		                        buttonYposition, buttonWidth, buttonHeight), "start")) {
								GameDataScript.playerName = nameText;

						Application.LoadLevel ("foodDetermine");
				}
						buttonYposition += buttonSpacing;

						if (GUI.Button (new Rect (Screen.width / 2 - buttonWidth / 2,
			                        buttonYposition, buttonWidth, buttonHeight), "Quit"))
						{
								Application.Quit ();
						}
				}
			


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}