using UnityEngine;
using System.Collections;

public class Hurt : MonoBehaviour {

	public AudioClip[] arrayOfSounds; //possible sounds
	public AudioSource myAudioSource; //where the sound comes from 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R)) { //if R is pressed 
			//then pick a random number based on how big the array is 
			int randomNumber = Random.Range (0, arrayOfSounds.Length) ; 
			//use that number to play a random sound
			myAudioSource.PlayOneShot ( arrayOfSounds[randomNumber] ); 

		}
	}
}
