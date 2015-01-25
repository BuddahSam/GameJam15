using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setNameScript : MonoBehaviour {

	public InputField setName;
	public string playerName;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		playerName = setName.text;
		GameDataScript.playerName = playerName;
	}
}
