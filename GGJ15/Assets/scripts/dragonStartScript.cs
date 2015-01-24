using UnityEngine;
using System.Collections;

public class dragonStartScript : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
		
		GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);
		//GameObject playerData = GameObject.Find ("playerData");
		//GameDataScript GameDataScript = GetComponents<GameDataScript>;
		//GameDataScript.playerName = playerData;
		
		GUI.Label(new Rect(10,10,Screen.width -10,Screen.height - 10), "Aah so it is dragons you are interested in. Many people who take an interest in dragons find themselves wishing" +
			"they hadn't. However there was one hero who managed to best the strongest dragon in the land, Ebonwing. He went by the name of " + "playerData" +
 			" and before him there was no hope for mankind. Only fire. But he took it upon himself to bring an end to the reign of the dragons to save humanity and bring peace to the land.");
		
		if(GUI.Button (new Rect(500, 300, 100, 50), "continue")){
			Application.LoadLevel ("");}
		

		
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
