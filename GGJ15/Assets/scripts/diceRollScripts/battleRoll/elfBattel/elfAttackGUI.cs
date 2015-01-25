using UnityEngine;
using System.Collections;

public class elfAttackGUI : MonoBehaviour {
	
	public Texture2D backGroundTexture;
	public GUISkin skin;
	public Texture2D healthTexture;
	public Texture2D enemyHealthTexture;
	
	
	void OnGUI()
	{
		GUI.skin = skin;
		
		GUI.TextArea(new Rect( 400, 10, 100, 50),"Your Attack Roll");
		
		GUI.DrawTexture (new Rect (0, 0, 175, 180), backGroundTexture);
		
		GUI.DrawTexture (new Rect (10, 20, 60, 60), healthTexture);
		
		GUI.Label (new Rect (100, 30, 60, 60), GameDataScript.health.ToString());
		
		GUI.DrawTexture (new Rect (10, 90, 60, 60), enemyHealthTexture);
		
		GUI.Label (new Rect (100, 102, 60, 60), GameDataScript.elf.ToString ());
		
	}
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
