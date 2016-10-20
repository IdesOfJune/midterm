using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Movement: MonoBehaviour {

	// "const" means constant, it means this value will never change, it's permanently hard-coded
	const float moveSpeed = 5f;
	public float thrust;  
	bool controllable; 
	public Text canMove; 
	public GameObject rArmRight; 
	public GameObject rArmLeft; 
	public GameObject lArmLeft; 
	public GameObject lArmRight; 

	// "SerializeField" exposes a variable to the inspector without making it public
	[SerializeField] float turnSpeed = 180f;
	Rigidbody rbody; 


	void Start () {

		rbody = GetComponent<Rigidbody> (); 
		controllable = false; 
		canMove.text = "You know what?"; 
		rArmRight = GameObject.Find ("raisedArmright");
		rArmRight.SetActive (false); 

		rArmLeft = GameObject.Find ("raisedArmleft"); 
		rArmLeft.SetActive (false); 

		lArmLeft = GameObject.Find ("loweredArmLeft");
		lArmLeft.SetActive (true); 

		lArmRight = GameObject.Find ("loweredArmRight"); 
		lArmRight.SetActive (true); 

		//player pose default

		StartCoroutine (Speech ()); 

	}

	IEnumerator Speech () {

		yield return new WaitForSeconds(2f); 

		canMove.text = "Screw  ice  skating!"; 

		yield return new WaitForSeconds (3f); 

		canMove.text = "I'm  gonna  bump  into \n as  many  things  as  possible."; 

		yield return new WaitForSeconds(3f); 

		canMove.text = "Let's go!"; 

		controllable = true; 

	}

	// Update is called once per frame
	void Update () {

		//Camera.main.transform.position = transform.position + new Vector3 (54.139f, 71.418f, 0f); 

		if (controllable) {

		// Input.GetAxis returns a float between -1 and 1
		// the number symbolizes the current input value
		// if it returns 0, that means we're not pressing anything
		float inputX = Input.GetAxis("Horizontal"); // [A] = -1, [D] = +1
		//float inputY = Input.GetAxis("Vertical"); // [W] = +1, [S] = -1

		// multiply by Time.deltaTime to make a behaviour framerate independent
		//transform.Translate(0f, 0f, inputY * moveSpeed * Time.deltaTime); // move forward / backward
		transform.Rotate(0f, inputX * turnSpeed * Time.deltaTime, 0f ); // turn left / right

		//player pose default 

		if (Input.GetKeyDown (KeyCode.W)) {

				rbody.AddRelativeForce (Vector3.left * thrust);

				controllable = false; 

				canMove.text = "Can't stop!";

				rArmLeft.SetActive (true); 
				rArmRight.SetActive (true); 

				lArmLeft.SetActive (false); 
				lArmRight.SetActive (false); 

				//player pose hands up! 


			} //relative force if bracket
				
		} //if controllable bracket

	} //void update bracket

	void OnCollisionEnter (Collision floor) {

		if(floor.gameObject.tag == "notfloor") {

			controllable = true; 
			canMove.text = "I can move!"; 

			rArmLeft.SetActive (false); 
			rArmRight.SetActive (false); 

			lArmLeft.SetActive (true); 
			lArmRight.SetActive (true); 

		}

		if (floor.gameObject.tag == "thing") {

			controllable = true; 
			canMove.text = "I can move!"; 

			rArmLeft.SetActive (false); 
			rArmRight.SetActive (false); 

			lArmLeft.SetActive (true); 
			lArmRight.SetActive (true); 

		}
			
	} //void oncollision enter bracket 

} //whole class bracket