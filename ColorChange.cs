using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {


    private Renderer rend;
    private PlayerMove pmScript;


    // Use this for initialization
    void Start() {

        rend = GetComponent<Renderer>();
        pmScript = GetComponent<PlayerMove>();
    }



    public IEnumerator ColorFlash(Color _newColor)
    {
        int i = 0;
        while (i < 10)
        {
            if (!(rend.material.color == _newColor))
                rend.material.color = _newColor;
            yield return new WaitForSeconds(0.1f);
            i++;
        }

        rend.material.color = Color.white;

    }

    public IEnumerator ColorSpeed()
    { 
        while(pmScript.speed > pmScript.maxSpeed)
        {
            if (!(rend.material.color == Color.yellow))
                rend.material.color = Color.yellow;
            yield return new WaitForSeconds(0.1f);
            
        }
        rend.material.color = Color.white;
    }

}
