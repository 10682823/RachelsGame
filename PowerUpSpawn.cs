using UnityEngine;
using System.Collections;
using System;

public class PowerUpSpawn : MonoBehaviour {

    //passing action as info<>
    public static Action<PowerUpSpawn> PowerSpawnAction;

    void Start()

    {
        //if anyone is subscribed
        if (PowerSpawnAction != null)
        {
            //this actual script sending out information
            PowerSpawnAction(this);
        }
    }


}
