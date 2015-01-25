using UnityEngine;
using System.Collections;

public class roadOption1Reward : MonoBehaviour {

	public void option1Reward(string Reward1)
	{
		Application.LoadLevel("theRoadEnd");
		GameDataScript.food++;
		GameDataScript.food++;
		GameDataScript.potion++;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
