using UnityEngine;
using System.Collections;

public class hunting : MonoBehaviour {

	public void elfFight(string elfFight)
	{
		Application.LoadLevel("elfBattle");
		GameDataScript.food+=2;
	}
	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
