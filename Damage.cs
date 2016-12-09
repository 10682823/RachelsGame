using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	private PlayerHealth pHealth;



	void Start () {
	
		//sets script in parent to call functions
		pHealth = GetComponentInParent<PlayerHealth> ();

	}

	void OnTriggerEnter()
	{
		pHealth.TakeDamage (10);
	}
}
