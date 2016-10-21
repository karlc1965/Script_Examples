using UnityEngine;
using System.Collections;

public class bulletDeath : MonoBehaviour {
	
	// Update is called once per frame
	void OnCollisionEnter () {
			Destroy (gameObject);
	
	}
}
