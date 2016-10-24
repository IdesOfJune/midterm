using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class BumpScript : MonoBehaviour {

	public static int bumpCount; //how many times player bumped into something
	public Text bumpDisplay; 
	bool hasBumped = false; 
	public AudioSource bumpSound; 

	// Use this for initialization
	void Start () {

		bumpCount = 0;  
		bumpDisplay.text = "I've bumped into" + bumpCount.ToString () + "objects!"; 
	
	} //void start 
	
	// Update is called once per frame
	void Update () {
	
		SetBumpDisplayText (); 

	} //void update 

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "thing" && hasBumped == false ) {

			bumpCount++; 
			bumpSound.Play (); 
			SetBumpDisplayText (); 
			Debug.Log ("bumped!");
			hasBumped = true; 

			StartCoroutine (Cooldown()); 

			} //if statement bracket 

		} //void on collisionenter bracket 

		IEnumerator Cooldown () {

			Debug.Log ("cooldown has started"); 
			yield return new WaitForSeconds (1f); 

			hasBumped = false; 
			Debug.Log ("hasBumped is false"); 

		} //IEnumerator bracket



	void SetBumpDisplayText () {

		bumpDisplay.text = "I've bumped into something " + bumpCount.ToString () + " time(s)!"; 

	}
}
