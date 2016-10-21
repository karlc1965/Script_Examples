using UnityEngine;
using System.Collections;
// Inheritance example  
public class Trigger : OtherTrigger { // inherit from script OtherTrigger

	void Start () {

	}
		
	void OnTriggerEnter() {
		CallMe (); // call public function CallMe on OtherTrigger.cs 
	}

	void OnTriggerExit() {
		ActivateMe (); // call public function CallMe on OtherTrigger.cs 
	}
}
