using UnityEngine;
using System.Collections;

public class forestheal : MonoBehaviour {

	public void forestSleep(string forestSleep)
	{
		Application.LoadLevel("forestEnd");
		GameDataScript.food -= 1;
		GameDataScript.health += 3;
	}
	



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
