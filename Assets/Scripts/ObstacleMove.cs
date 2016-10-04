using UnityEngine;
using System.Collections;

public class ObstacleMove : MonoBehaviour {

	public float speed =5f; // speed
	public float length= 10f; // length from 0 to endpoint.
	public float posX = 0f; // Offset

	void Update() {
		Vector3 pos = new Vector3 ( posX+Mathf.PingPong (speed * Time.time, length),0, 0);
		transform.position = pos;
	}
}
