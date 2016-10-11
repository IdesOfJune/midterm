using UnityEngine;
using System.Collections;

public class ObstacleMove : MonoBehaviour {

	public float speed = 5f; // speed
	public float length= 20f; // length from 0 to endpoint.
	public float posX; 
	public float posY; 
	public float posZ; 


	void Update() {
		Vector3 pos = new Vector3 (posX+Mathf.PingPong (speed * Time.time, length),posY,posZ);
		transform.position = pos;
	}
}
