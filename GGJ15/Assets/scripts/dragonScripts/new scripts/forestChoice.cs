using UnityEngine;
using System.Collections;

public class forestChoice : MonoBehaviour {

	public void goHunt(string goHunt)
	{
		Application.LoadLevel("hunting");
	}
	
	public void sleepForestButton(string sleepForestButton)
	{
		Application.LoadLevel ("healthRegainSleepForest");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
