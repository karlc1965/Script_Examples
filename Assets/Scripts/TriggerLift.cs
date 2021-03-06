using UnityEngine;
using System.Collections;

public class TriggerLift : MonoBehaviour {
	private Animator animator;
	public GameObject lift;
	public GameObject liftText;
	public bool inLift;
	public bool liftUp;
	void Awake() {
		animator = GetComponent<Animator>();
	}

	void Start() {
		inLift = false;
	}

	void Update() {
		if (Input.GetButtonDown ("LiftOn") && inLift == true) {
			liftText.SetActive(false);
			liftUp = !liftUp; // toggle liftUp bool ON/OFF
			if (liftUp) { // if true
				LiftUp ();
			}
			else if (!liftUp) { // if false
				LiftDown();
			}
		}
	}

	void OnTriggerEnter(Collider player) {
		if (player.tag == "Player") {
			inLift = true; // set bool to true
			print ("I am in the Lift");
			player.transform.parent = lift.transform; // parent player(collider player) to lift
			liftText.SetActive(true);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "Player" ) {
			inLift = false; // set bool to false
			print ("I am NOT in the Lift");
			other.transform.parent = null; // unparent player(collider player) to lift
		}
	}

	void LiftUp() {
		liftUp = true;
		animator.SetBool ("Up", true); // play animation in Lift animator controller component in animator located on the lift gameobject
	}

	void LiftDown() {
		liftUp = false;
		animator.SetBool ("Up", false); // play animation in Lift animator controller component in animator located on the lift gameobject
	}
}

