using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class TimeKeep : MonoBehaviour {

	public float timeLeft;  
	public Text timeDisplay; 


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		timeLeft -= Time.deltaTime; 
		timeDisplay.text = "I have " + string.Format("{0:0.0}",timeLeft) + " seconds left";  //timeLeft.ToString () + " more seconds"; 

		if (timeLeft <= 0f) {

			SceneManager.LoadScene (3); 

		}
	
	}
}
