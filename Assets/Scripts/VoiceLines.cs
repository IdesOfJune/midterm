using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class VoiceLines : MonoBehaviour {

	public string[] exclamations; 
	public Text voiceText; 

	// Use this for initialization
	void Start () {
	
		SetVoiceText (); 
		voiceText.text = ""; 

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnCollisionEnter () {

		//if (other.tag == "player") {
			Debug.Log (exclamations [Random.Range (0, exclamations.Length)]); 
			SetVoiceText (); 
		//}
	}

	void SetVoiceText () {

		voiceText.text = exclamations [Random.Range (0, exclamations.Length)];


	}
}
