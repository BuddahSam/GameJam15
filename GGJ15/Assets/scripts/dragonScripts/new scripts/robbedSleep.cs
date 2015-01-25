using UnityEngine;
using System.Collections;

public class robbedSleep : MonoBehaviour {

	public void robbedContinue(string robbedContinue)
	{
		Application.LoadLevel("theRoadEndBandits");
		GameDataScript.food-= GameDataScript.food/2;
		GameDataScript.food--;
		GameDataScript.gold-= GameDataScript.gold/2;
		GameDataScript.health+=3;
		//Debug.Log(GameDataScript.gold + "gold");
		//Debug.Log (GameDataScript.food + "food");
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
