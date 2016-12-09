using UnityEngine;
using System.Collections;

public class PowerUpCollide : MonoBehaviour {

	private PlayerMove player;
	public int speedFactor = 20;
    private ColorChange ccScript;

	void Start(){
		player = GetComponentInParent<PlayerMove> ();
        ccScript = GetComponentInParent<ColorChange>();
	}

	// Use this for initialization
	void OnTriggerEnter () {
		StartCoroutine (player.SpeedUp (true, speedFactor));
        StartCoroutine(ccScript.ColorSpeed());
	}


}
