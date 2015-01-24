using UnityEngine;
using System.Collections;

public class TheRoadBanditEncounterScript : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
				GUI.skin = skin;
		
				GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);

		
		GUI.Label (new Rect (10, 10, Screen.width - 10, Screen.height - 10), "The next day after a few hours travelling he sees a town on the horizon on the road, but between " +
			"our hero and that town a pair of men stand on the road, arms folded and a mean look on their faces. These men spot you and draw swords. He sees no other option " +
			"than to stand and fight.");
		
				if (GUI.Button (new Rect (500, 300, 100, 50), "To battle!!")) {
						Application.LoadLevel ("banditBattle");
				}
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
