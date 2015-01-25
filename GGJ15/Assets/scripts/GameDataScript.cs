using UnityEngine;
using System.Collections;

public class GameDataScript : MonoBehaviour {

	public static string playerName="";
	public static int food=0;
	public static int health =10;
	public static int gold = 0;
	public static int sword = 0;
	public static int potion = 0;
	public dieValue currentValue;


	// Use this for initialization
	void Start () {
		Debug.Log (dieValue.currentValue);

		

		//telling the game to keep this data	
		DontDestroyOnLoad(this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}