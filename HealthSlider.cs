using UnityEngine;
using System.Collections;
using System;

public class HealthSlider : MonoBehaviour {


    public static Action<HealthSlider> HealthSliderAction;

    void Start()

    {
       if(HealthSliderAction != null)
        //if (EndGameAction != null)
        {
            //this actual script sending out information
            Application.Quit();
        }
    }
}
