using UnityEngine;
using System.Collections;

public class healthRegainSleepRoadScript : MonoBehaviour {


	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
				GUI.skin = skin;
		
				GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);
		
				GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "Taking the time to rest from his travels our hero finds himself feeling a bit better and his" +
					" wounds less weary (gain +3 health)");
		
				if (GUI.Button (new Rect (500, 300, 100, 50), "Huzzah!")) {
				GameDataScript.health ++;		
				GameDataScript.health ++;	
				GameDataScript.health ++;	
			Debug.Log(GameDataScript.health);
				Application.LoadLevel ("theRoadEndBandits");
				}

		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
