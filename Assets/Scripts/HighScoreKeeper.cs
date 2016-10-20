using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class HighScoreKeeper : MonoBehaviour {

	public Text bumpScore; 

	// Use this for initialization
	void Start () {

		bumpScore.text = "You managed to bump into " + BumpScript.bumpCount + " objects!"; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
