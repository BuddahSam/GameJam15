using UnityEngine;
using System.Collections;

public class roadOption1Script : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
				GUI.skin = skin;
		
				GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);
		
				GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "Shocked at your tale they offer you food to help you on your journey (+2 food!)");
		
				if (GUI.Button (new Rect (500, 300, 100, 50), "Thank You!")) {
						GameDataScript.food++;
						GameDataScript.food++;
						Application.LoadLevel ("theRoadEnd");
				}
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
