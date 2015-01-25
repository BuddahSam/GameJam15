using UnityEngine;
using System.Collections;

public class manDieDefendRoll : MonoBehaviour {
	public static float deltaV = 0.1f;
	public object die;
	public static bool grounded = false;
	public Transform groundCheck;
	public GameObject whatIsGround;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (grounded && rigidbody.velocity.magnitude < manDieDefendRoll.deltaV) {
			{
				StartCoroutine(DiceTimer());
				
			}
		}
		
	}
	
	private void OnCollisionEnter(Collision collisionInfo)
	{
		Debug.Log (collisionInfo.gameObject.name);
		if (collisionInfo.gameObject.tag == "table")
		{
			grounded = true;
		}
	}
	
	private void OnCollisionExit(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "table")
		{
			grounded = false;
		}
	}
	
	IEnumerator DiceTimer(){
				yield return new WaitForSeconds (2);
				//Debug.Log(die1Value.currentValue);
				if (die1Value.currentValue >= 5) {
						GameDataScript.health = GameDataScript.health - 2;
		}
		
		
		if (GameDataScript.health >= 1)
		{
			
			Application.LoadLevel ("manBattleAttack");
		}
		
		else 
			
		{
			Debug.Log ("You're Deed");
			Application.LoadLevel("deathScreen");
			
		}	
				}

	}