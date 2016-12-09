using UnityEngine;
using System.Collections;

public class PowerUpAddHealth : PowerUp {

	//private PlayerHealth AddHealth;

	protected void OnTriggerEnter(Collider other)
	{
		other.GetComponentInParent<PlayerHealth> ().AddHealth (15);
        base.OnTriggerEnter();
	}


}
