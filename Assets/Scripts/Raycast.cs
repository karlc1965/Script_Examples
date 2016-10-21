using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	// raycast script
	// raycast and raycast draw ray

	public float distance; // distance of the ray
	public Vector3 direction; // direction and length of the ray

	void Update () {
		RaycastHit hit;
		Ray ray = new Ray (transform.position, direction);
		Debug.DrawRay(transform.position, direction, Color.green);

		if(Physics.Raycast( ray, out hit, distance)) {
			if(hit.collider.tag == "Ball") {
				Debug.Log ("I hit the Ball");
			}
		}
	}
}
