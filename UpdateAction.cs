using UnityEngine;
using System.Collections;
using System;

public class UpdateAction : MonoBehaviour {

	public static Action<KeyCode> MoveInput;

	
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			MoveInput (KeyCode.UpArrow);
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			MoveInput (KeyCode.DownArrow);
		}
		//can only turn right if moving
		if (Input.GetKey (KeyCode.RightArrow) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))) 
		{
			MoveInput (KeyCode.RightArrow);
		}
		//can only move left is moving
		if (Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))) 
		{
			MoveInput (KeyCode.LeftArrow);
		}
	}
	
}

