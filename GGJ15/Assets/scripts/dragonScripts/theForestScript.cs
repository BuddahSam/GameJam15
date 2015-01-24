using UnityEngine;
using System.Collections;

public class theForestScript : MonoBehaviour {


	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
		GUI.skin = skin;
		
		GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);

		GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "Entering the forest " + GameDataScript.playerName + " is immediately enclosed and surrounded by a thicket of trees" +
			" and finds advancing difficult. Using his sword to hack his way through the brushes and low hanging branches he begins to make headway into the dense foliage until he " +
			"finds a tree which looks suitable for climbing. Deciding to climb this to see what way to travel he start to ascend. Upon reaching the top of the canopy he see's the " +
			"other edge of the forest and knows what way to go. But it is also getting dark. He can use this time to hunt or he can just rely on his own supplies lest face the wrath " +
			"of the forest denizens.");
		
		if (GUI.Button (new Rect (200, 400, 100, 50), "Go hunting"))
		{
			Application.LoadLevel ("elfBattle");
		}
		
		if (GUI.Button (new Rect (800, 400, 140, 50), "Use your own food")) 
		{
			Application.LoadLevel ("healthRegainSleepForest");
		}
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
