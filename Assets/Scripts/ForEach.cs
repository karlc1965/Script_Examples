using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

//	public bool nearLight = false;

	public bool on;
	Component[] light;

	void Start () {
		on = true;
	}
		
	void Update() {

		if (Input.GetButtonDown ("LightSwitch")) {
			// toggle button 
			on = !on;
			if (on)
				// call function
				LightsOn();
			if (!on)
				// call function
				LightsOff();
		}
	}

	void LightsOn() {

		// creat array with all gameobjects tagged "Light"
		GameObject[] lightOn = GameObject.FindGameObjectsWithTag("Light");
		// name all gameobjects onlight and grab them all
		foreach (GameObject onLight in lightOn) {
			// select each gameobject and look for children with components that contain the type of Light and enable
			onLight.GetComponentInChildren <Light>().enabled = true;

		}
	}

	void LightsOff() {
		// creat array with all gameobjects tagged "Light"
		GameObject[] lightOff = GameObject.FindGameObjectsWithTag("Light");
		// name all gameobjects onlight and grab them all
		foreach (GameObject offLight in lightOff) {
			// select each gameobject and look for children with components that contain the type of Light and disable
			offLight.GetComponentInChildren <Light>().enabled = false;
		}
			
	}
}


/*
	/// </summary>	/////////////////////////////////////// SINGLE LIGHT ////////////////////////////////////////////////////////////////////
	private Light light;

	void Start () {
		//	on = true;
		light = GetComponent<Light>();
	}


	void Update() {
		if (Input.GetButtonDown ("LightSwitch")) {
			light.enabled = !light.enabled;
		}
*/

