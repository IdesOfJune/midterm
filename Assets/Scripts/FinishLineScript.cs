using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class FinishLineScript : MonoBehaviour {

	int lapCount; //how many times player finished a lap
	public Text lapDisplay; //the element that displays number of finished laps 
	bool isColliding;  

	// Use this for initialization
	void Start () {

		lapCount = 0;  
		lapDisplay.text = lapCount.ToString () + "  laps completed"; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
		isColliding = false; 

	}

	void OnTriggerEnter () {

		if (isColliding)
			return;
		isColliding = true; 
		Debug.Log ("triggered!"); 
		lapCount++;
		Debug.Log ("you have passed the line" + lapCount.ToString () + "times"); 
		SetLapDisplayText (); 



	}

	void SetLapDisplayText () {

		if (lapCount >= 3) {

			lapDisplay.text = "Yay! I completed 3 laps!"; 

		} else {

			lapDisplay.text = lapCount.ToString () + "laps completed"; 

		}
	}
}
