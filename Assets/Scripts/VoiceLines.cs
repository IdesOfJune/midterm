using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class VoiceLines : MonoBehaviour {

	public string[] exclamations; 
	public Text voiceText; 
	bool hasBumped = false; 

	// Use this for initialization
	void Start () {
	
		SetVoiceText (); 
		voiceText.text = ""; 

	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "player" && hasBumped == false) {
			Debug.Log (exclamations [Random.Range (0, exclamations.Length)]); 
			SetVoiceText (); 
			hasBumped = true; 
			StartCoroutine (Cooldown()); 


		}
	} //void on collision enter 

	IEnumerator Cooldown () {

		Debug.Log ("cooldown has started"); 
		yield return new WaitForSeconds (2f); 

		hasBumped = false; 
		Debug.Log ("hasBumped is false"); 

	} //IEnumerator bracket


	void SetVoiceText () {

		voiceText.text = exclamations [Random.Range (0, exclamations.Length)];


	}
}
