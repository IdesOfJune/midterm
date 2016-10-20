using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour {

	public GameObject momLine1; 
	public GameObject myLine1; 
	public GameObject momLine2;
	public GameObject momLine3;
	public GameObject myLine2; 

	// Use this for initialization
	void Start () {

		StartCoroutine (Begin()); 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Begin() {

		yield return new WaitForSeconds (1);

		momLine1.SetActive (true); 

		yield return new WaitForSeconds (3); 

		momLine1.SetActive (false); 

		yield return new WaitForSeconds (1);

		myLine1.SetActive (true); 

		yield return new WaitForSeconds (3); 

		myLine1.SetActive (false); 

		yield return new WaitForSeconds (1);

		momLine2.SetActive (true); 

		yield return new WaitForSeconds (3); 

		momLine2.SetActive (false); 

		yield return new WaitForSeconds (1);

		momLine3.SetActive (true); 

		yield return new WaitForSeconds (3); 

		momLine3.SetActive (false); 

		yield return new WaitForSeconds (1);

		myLine2.SetActive (true); 

		yield return new WaitForSeconds (3); 

		myLine2.SetActive (false); 

		yield return new WaitForSeconds (1);

		SceneManager.LoadScene (0); 

	}


}
