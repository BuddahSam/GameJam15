using UnityEngine;
using System.Collections;

public class dragonFirstChoice : MonoBehaviour {

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
		
		GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), GameDataScript.playerName + "'s story begins after his village was burned to the ground by Ebonwing and in his rage vowed to end the dragons life. " +
		           "Searching among the rubble he found his fathers sword, broken and burnt (3 damage, hits on 3+), as well as a few coins and some burnt food. He took it anyway as it was all he had " +
		           "left. Setting off from his ruined house he thought about how best to deal with the dragon. He could travel along the road to the mountain where he resided. This would be " +
		           "quicker but the roads are dangerous and often people are attacked by raiders or worse. Or he could take the path through the forest. The forest would be slow but he could " +
		           "hunt for food and find plenty of water in the streams to keep himself supplied, although the elfs who live there might not be happy about him killing the wildlife they " +
		           "consider theirs.");
		
				if (GUI.Button (new Rect (200, 400, 100, 50), "Take the road"))
				{
						Application.LoadLevel ("theRoad");
				}

			if (GUI.Button (new Rect (800, 400, 140, 50), "Go through the forest")) 
			{
				Application.LoadLevel ("theForest");
			}
				
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
