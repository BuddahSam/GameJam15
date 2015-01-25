using UnityEngine;
using System.Collections;

public class dragonFirstChoiceButton : MonoBehaviour {

	public void roadButton(string roadButton)
	{
		Application.LoadLevel("theRoad");
	}
	
	public void forestButton(string forestButton)
	{
		Application.LoadLevel ("theForest");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
