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
		           " to pick up some supplies for his travels to the dragons lair.") ;

		if (GUI.Button (new Rect (200, 400, 170, 50), "Purchase 1 food (5 Gold)"))
		{
					
					if (GameDataScript.gold - 5 < 0)
					{
						Debug.Log ("Insufficient Gold");
					}
					else
					{
						GameDataScript.gold -= 5;
						GameDataScript.food ++;
					}
		
		}



		if (GUI.Button (new Rect (450, 400, 220, 50), "Purchase Shortsword for 30 Gold \n (5 Damage hit on 4+)"))
		{
			
			if (GameDataScript.gold - 30 < 0)
			{
				//Debug.Log ("Insufficient Gold");
			}
			else if (GameDataScript.sword >= 1)
			{
				//Debug.Log ("You got a better sword");
			}

			else 
			{
				GameDataScript.gold -= 30;
				GameDataScript.sword ++;
				//Debug.Log (GameDataScript.sword);
			}
				
		}

		if (GUI.Button (new Rect (750, 400, 220, 50), "Purchase Potion of Healing \n (Heals 2 Health) 10 Gold"))
		    {

			if (GameDataScript.gold - 10 >= 0)
			{
				//Debug.Log ("Insufficient Gold");
			}
		
			else 
			{
				GameDataScript.gold -= 10;
				GameDataScript.potion ++;
				//Debug.Log (GameDataScript.potion);
			}
		}

		if (GUI.Button (new Rect (500, 300, 120, 50), "Leave Town")) {
						Application.LoadLevel ("townExit");
				}
		
		
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
