using UnityEngine;
using System.Collections;

public class ObstacleMoveVertical : MonoBehaviour {

	public float speed; // speed
	public float length; // length from 0 to endpoint.
	public float posX; 
	public float posY; 
	public float posZ; 


	void Update() {
		Vector3 pos = new Vector3 (posX,posY,posZ+Mathf.PingPong (speed * Time.time, length));
		transform.position = pos;
	}
}
