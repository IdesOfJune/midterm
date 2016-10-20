using UnityEngine;
using System.Collections;

public class HitSound : MonoBehaviour {

	public AudioSource myAudioSource; 

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

			//don't interrupt

		if (Input.GetKeyDown (KeyCode.Space)) {

			//myAudioSource.play (); 

		//}

		//if (myAudioSource.isPLaying  == false ) { //don't interrupt 
			//	myAudioSource.play(); 
			//}

			//play new instance of sound each time

			//toggle a looping sound
			if (myAudioSource.isPlaying == false) {
				myAudioSource.loop = true; //make sure it is set to loop
				myAudioSource.Play (); 

			} else {
				myAudioSource.loop = false; 
				myAudioSource.Stop (); 
			}

	
	}
}
}	 