using UnityEngine;
using System.Collections;

public class PickupText : MonoBehaviour {

	public GameObject text;


	void OnTriggerEnter(Collider col){
		if(col.tag == "Player") {
		Invoke ("DisplayText", 0);
		}
	}

	void OnTriggerExit(Collider col){
		if(col.tag == "Player") {
			DisplayTextOff ();
		}
	}

	void DisplayText() {
		text.SetActive (true);
		Invoke ("DisplayTextOff", 3);
	}

	void DisplayTextOff() {
		text.SetActive (false);
	}
}
