using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour, IHealth{

	public float Health = 100;
	public Slider MySlider;
	private float maxHealth;
    private ColorChange ccScript;




    public float AddHealth (float _amount)

    {
        StartCoroutine(ccScript.ColorFlash(Color.blue));
		Health += _amount;
		if(Health > maxHealth)
		{
			Health = maxHealth;
		}
		MySlider.value = Health/maxHealth;
		return Health;
	}

	public float TakeDamage (float _amount)
	{
        StartCoroutine(ccScript.ColorFlash(Color.red));
		Health -= _amount;
		MySlider.value = Health/maxHealth;
		return Health;
	}

	void Start () {
	
		maxHealth = Health;
        ccScript = GetComponent<ColorChange>();
	}

}
