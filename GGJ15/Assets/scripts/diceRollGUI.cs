using UnityEngine;
using System.Collections;

public class diceRollGUI : MonoBehaviour {

	public Texture2D backGroundTexture;
	public GUISkin skin;
	
	void OnGUI()
	{
				GUI.skin = skin;
		
				GUI.DrawTexture (new
		                 Rect (0, 0, 175, 250), backGroundTexture);

		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
