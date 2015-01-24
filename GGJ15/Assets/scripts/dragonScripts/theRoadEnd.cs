using UnityEngine;
using System.Collections;

public class theRoadEnd : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
		GUI.skin = skin;
		
		GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);

		
		GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "Departing from the caravan " + GameDataScript.playerName + " finds he doesn't get far before the sun begins to set " +
			"and feels it is time to stop and rest. He could either sleep beside the road and hope nobody passes by or he could spend time looking for somewhere further afield " +
			"from the road to rest.");
		
		if (GUI.Button (new Rect (200, 400, 120, 50), "Sleep by the road"))
		{
			Application.LoadLevel ("sleepRoad");
		}
		
		if (GUI.Button (new Rect (800, 400, 140, 50), "sleep further afield")) 
		{
			Application.LoadLevel ("healthRegainSleepRoad");
		}
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
