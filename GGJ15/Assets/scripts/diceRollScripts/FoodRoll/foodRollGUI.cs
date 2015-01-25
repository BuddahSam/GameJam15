using UnityEngine;
using System.Collections;

public class foodRollGUI : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;
	public Texture2D healthTexture;
	public Texture2D foodTexture;
	public Texture2D goldTexture;
 	
	
	void OnGUI()
	{
				GUI.skin = skin;

		GUI.TextArea(new Rect( 400, 10, 100, 50),"Roll for your starting food");

				GUI.DrawTexture (new Rect (0, 0, 175, 250), backGroundTexture);

		GUI.DrawTexture (new Rect (10, 20, 60, 60), healthTexture);

		GUI.Label (new Rect (100, 30, 60, 60), GameDataScript.health.ToString());

		GUI.DrawTexture (new Rect (10, 90, 60, 60), foodTexture);

		GUI.Label (new Rect (100, 102, 60, 60), GameDataScript.food.ToString ());

		GUI.DrawTexture (new Rect (10, 160, 60, 60), goldTexture);

		GUI.Label (new Rect (100, 170, 60, 60), GameDataScript.gold.ToString ());
		}
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
