using UnityEngine;
using System.Collections;

public class OpenCloseDoor : MonoBehaviour {
		
//First, we will create a reference called doorAnimator so we can talk to the Animator component on the game object.
//The Animator is what listens to our instructions and tells the mesh which animation to use.
	private Animator doorAnimator;
	// bool for "Open Door" toggle
	public bool open = false;
	// bool for if we are in the sphere collider trigger on the hinge
	public bool nearDoor;

// The start method is called when the script is initalized, before other stuff in the scripts start happening.
	void Start () {
//We have a reference called doorAnimator but we need to fill that reference with an Animator component.
//We can do that by 'getting' the animator that is on the same game object this script is appleid to.
	    doorAnimator = GetComponent<Animator>();
		nearDoor = false;
	}

	void Update() {
		
		if (Input.GetButtonDown ("Open") && nearDoor) {
			
			open = !open;
			if (open)
				doorAnimator.SetBool ("Open", true);
			else if (!open)
				doorAnimator.SetBool ("Open", false);
		}
	}

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player") {
			nearDoor = true;
		}
	}

		void OnTriggerExit (Collider col) {
			if(col.tag == "Player") {
				nearDoor = false;
		}
	}
}


