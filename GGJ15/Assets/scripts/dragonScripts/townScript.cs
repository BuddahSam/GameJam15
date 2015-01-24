using UnityEngine;
using System.Collections;

public class townScript : MonoBehaviour {
	
	
	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
		GUI.skin = skin;
		
		GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);
		
		GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "After reaching the town he sees that there are a few shops and an alchemist where he might be able" +
		           "pick up some supplies for his travels to the dragons lair.") ;

		if (GUI.Button (new Rect (200, 400, 100, 50), "Purchase 1 food (5 Gold)"));

		if (GameDataScript.gold - 5 < 0);
			{
					Debug.Log ("Insufficient Gold");
			}

		else
		{
			GameDataScript.gold --;
			GameDataScript.gold --;
			GameDataScript.gold --;
			GameDataScript.gold --;
			GameDataScript.gold --;
			GameDataScript.food ++;
		}



				

			    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
