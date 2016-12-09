using UnityEngine;
using System.Collections;
using System;

public abstract class PowerUp : MonoBehaviour {
	//passing action as info<>
	public static Action<PowerUp> PowerAction;

	void Start ()

	{
		//if anyone is subscribed
		if (PowerAction != null) 
		{
			//this actual script sending out information
			PowerAction (this);
		}
	}

    protected void OnTriggerEnter()
    {
        gameObject.SetActive(false);
    }
}
