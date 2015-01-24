using UnityEngine;
using System.Collections;

public class GameDataScript : MonoBehaviour {

	//setting a string for the player to be refernced later in other code
	public string playerName="";
	
	// Use this for initialization
	void Start () {
		
		//telling the game to keep this data	
		DontDestroyOnLoad(this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}