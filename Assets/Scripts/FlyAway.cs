using UnityEngine;
using System.Collections;

public class FlyAway : MonoBehaviour {

	Rigidbody conebody;
	public float coneThrust;


	// Use this for initialization
	void Start () {

		conebody = GetComponent<Rigidbody> (); 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "player") {
			Debug.Log ("collision!"); 
			conebody.AddRelativeForce (Random.onUnitSphere * coneThrust);

		}
			


	}
}
