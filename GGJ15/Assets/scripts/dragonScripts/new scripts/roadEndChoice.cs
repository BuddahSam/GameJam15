using UnityEngine;
using System.Collections;

public class roadEndChoice : MonoBehaviour {


	public void sleepRoad(string sleepRoad)
	{
		Application.LoadLevel("sleepRoad");
	}
	
	public void sleepAfield(string sleepAfield)
	{
		Application.LoadLevel ("healthRegainSleepRoad");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
