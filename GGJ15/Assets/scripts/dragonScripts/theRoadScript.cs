using UnityEngine;
using System.Collections;

public class theRoadScript : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
				GUI.skin = skin;
		
				GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);
		
				GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "As " + GameDataScript.playerName + " travelled down the road a party of travellers accompanying a caravan travel towards him." +
						"They greet him in a friendly manner and ask him what his business is on the road.");
		
				if (GUI.Button (new Rect (200, 300, 150, 50), "Tell them your quest")) {
						Application.LoadLevel ("roadOption1");
				}
				if (GUI.Button (new Rect (450, 300, 220, 50), "Politely decline and be on your way")) {
						Application.LoadLevel ("theRoadEnd");
				}
				if (GUI.Button (new Rect (750, 300, 240, 50), "Attack the caravan in the hope of loot")) {
						Application.LoadLevel ("roadOption2");
				}
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
