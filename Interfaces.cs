using UnityEngine;
using System.Collections;

public interface IHealth
{
	float AddHealth (float _amount);
	float TakeDamage (float _amount);
}

