using UnityEngine;
using System.Collections;

public class sleepAfield : MonoBehaviour {

	public void sleepHeal(string sleepHeal)
	{
		Application.LoadLevel("theRoadEnd");
		GameDataScript.health += 3;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
