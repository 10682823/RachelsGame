using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
	//static varible can only use static, buttons cant call static functions.
	public static void LoadMenu ()
	{
		//tell what script it is coming from (Static Variables)
		SceneManager.LoadScene(StaticVariables.MenuSceneIndex);
	}
	public static void LoadLevel ()
	{
		//tell what script it is coming from (Static Variables)
		SceneManager.LoadScene(StaticVariables.LevelSceneIndex);
	}
	//Stops everything
	public static void QuitGame()
	{
		Application.Quit ();
	}




	//button will decide which function above to call, everything inside functions are private.
	public void ButtonLoad(int _scene)
	{
		switch (_scene) 
		{
		case -1:
			QuitGame ();
			break;			

		case 0:
			LoadMenu ();
			break;

		case 1:
			LoadLevel ();
			break;
		}

	}

	public void ButtonLoad(string _scene)
	{

		_scene.ToUpper ();
		switch (_scene) 
		{
		case "QUIT":
		case "EXIT":
			QuitGame ();
			break;

		case "MENU":
		case "START":
			LoadMenu ();
			break;

		case "LEVEL":
		case "FIRST LEVEL":
		case "MAIN GAME":
			LoadLevel ();
			break;
		

		}

	}

}
