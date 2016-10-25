using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class PlayAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R)) {
			//if player presses R the game resets by reloading the current scene
			SceneManager.LoadScene( 2 ); 

		}

	}
}
