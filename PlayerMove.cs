using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


	public float speed = 30;
	public float turnSpeed = 5;
	public float maxSpeed;
	private float speedTime = 0.1f;




	private CharacterController myCC;



	void Start () {

		myCC = GetComponent<CharacterController> ();
		maxSpeed = speed;

		//subscribing to the UpdateAction Script
		UpdateAction.MoveInput += moveHandler;
		UpdateAction.MoveInput += rotateHandler;
	
	}


	void moveHandler(KeyCode _input)
	{
		//checks for appropriate input 
		if (_input == KeyCode.UpArrow)
		myCC.Move (transform.forward * speed * Time.deltaTime);
		if (_input == KeyCode.DownArrow)
		myCC.Move (transform.forward * -speed * Time.deltaTime);
	}
	void rotateHandler(KeyCode _input)
	{
		if (_input == KeyCode.RightArrow)
		transform.Rotate (0, turnSpeed * Time.deltaTime, 0);
		if (_input == KeyCode.LeftArrow)
		transform.Rotate (0, -turnSpeed * Time.deltaTime, 0);
	}

	public IEnumerator SlowDown(int _iterations = 10){
	
		for (int i = 0; i < _iterations; i++) {

			speed = speed - (maxSpeed / 20);
		
			yield return new WaitForSeconds (speedTime);
		}

	}


	public IEnumerator SpeedUp(bool arrowSpeedUp = false, int _iterations = 10){

		for (int i = 0; i < _iterations; i++) {
			speed = speed + (maxSpeed / 20);

			yield return new WaitForSeconds (speedTime);
		}

		if (arrowSpeedUp) {
			yield return new WaitForSeconds (1f);

			StartCoroutine (SlowDown (_iterations));
			arrowSpeedUp = false;
		}

	}
}
