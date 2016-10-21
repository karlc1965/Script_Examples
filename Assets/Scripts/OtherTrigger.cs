using UnityEngine;
using System.Collections;
// inheritance example script
public class OtherTrigger : MonoBehaviour {

	public GameObject light;

	public void CallMe() {
		// this function is called from Trigger.cs OnTriggerEnter
		print ("called from trigger");
		light.SetActive (false);
	}

	public void ActivateMe() {
		// this function is called from Trigger.cs OnTriggerEnter
		print ("called from trigger");
		light.SetActive (true);
	}
}
