using UnityEngine;
using System.Collections;

public class parent : MonoBehaviour {

	// Use this for initialization
	protected void Start () {

        myFunction();

	
	}

    protected virtual void myFunction()

    {
        print("Parent Function Called");
    }

}
