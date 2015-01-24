using UnityEngine;
using System.Collections;

public class tavernScript : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
	
				GUI.DrawTexture (new
		                 Rect (0, 0, Screen.width, Screen.height), backGroundTexture);



		GUI.Label(new Rect(10,10,Screen.width -10,Screen.height - 10), "Like all good fantasy tales begin, you find yourself in a tavern. After a particularly long " +
			"evening of drinking and social adventure you find yourself in the company of a wizened old man who earlier introduced himself as Cecard Dain, " +
			"a grand storyteller of sorts. He has enthralled you with his tales of daring and heroism and left you thirsting for more. After bringing more drinks to the table he sits " +
			"down, looks you in the eye and says...");
	
		GUI.Label (new Rect (10,Screen.height/2, Screen.width -10, Screen.height -10), " So young man, what story do you wish to hear now? " +
						"A tale of daring exploits and dragons or a story of long lost treasure guarded by a band of bloodthirsty bandits?");

		if(GUI.Button (new Rect(200, 400, 100, 50), "A tale of scale")){
			Application.LoadLevel ("dragonStartScene");}

		if(GUI.Button (new Rect(800, 400, 150, 50), "The Gin Alley Bandits")){
			Application.LoadLevel ("ginAlleyStart");}


		                        }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
