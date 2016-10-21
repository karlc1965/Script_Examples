using UnityEngine;
using System.Collections;

public class BallVector : MonoBehaviour {

	public float ballASpeed;
	//Transform target;
	public Vector3 curveDirection;
	public Vector3 heightDirection;
	public float liftTime;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (transform.forward * ballASpeed, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		float step = ballASpeed * Time.deltaTime;
	}

	void FixedUpdate() {
		GetComponent<Rigidbody>().AddForce(curveDirection * liftTime);
	}
}
