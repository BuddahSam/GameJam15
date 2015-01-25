using UnityEngine;
using System.Collections;

public class caravanOptions : MonoBehaviour {

	public void option1Button1(string option1)
	{
		Application.LoadLevel("RoadOption1");
	}
	
	public void optionButton2(string option2)
	{
		Application.LoadLevel("theRoadEnd");
	}
	
	public void manBattleButton(string manBattle)
	{
		Application.LoadLevel ("manBattle");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
