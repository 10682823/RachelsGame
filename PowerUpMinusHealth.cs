using UnityEngine;
using System.Collections;

public class PowerUpMinusHealth : PowerUp {

	//private PlayerHealth MinusHealth;

	protected void OnTriggerEnter(Collider other)
	{
		other.GetComponentInParent<PlayerHealth> ().TakeDamage (15);
        base.OnTriggerEnter();
	}


}
