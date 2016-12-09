using UnityEngine;
using System.Collections;

public class SandCollision : MonoBehaviour {

	private PlayerMove player;

	void Start(){
		player = GetComponentInParent<PlayerMove> ();
	}

	// Use this for initialization
	void OnTriggerEnter () {
		StartCoroutine (player.SlowDown ());
	}
	
	// Update is called once per frame
	void OnTriggerExit () {
		StartCoroutine (player.SpeedUp ());
	}
}
