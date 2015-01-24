using UnityEngine;
using System.Collections;

public class forestEndScript : MonoBehaviour {

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
		
				GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "The next day he makes his way through the forest. It takes many hours but eventually he finds his " +
						"way to the edge and he can see a small town on the horizon. He decides it's a good idea to go there and makes his way towards it.");
		
				if (GUI.Button (new Rect (500, 400, 120, 50), "Continue to town")) {
						Application.LoadLevel ("town");
				}

		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
