using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectable : MonoBehaviour {

	GameObject collectable;
	public int pickUpCount;
	public Text PickUpScore;
	void Start() {
		collectable = GameObject.FindWithTag ("Collectable");
		pickUpCount = 0;
	}

	void OnTriggerEnter(Collider col) {
		if(col.tag == "Collectable") {
			Debug.Log ("Pick up here!!!");
			Destroy (col.gameObject);
			AddToScore ();
		}
	}

	void AddToScore() {
		pickUpCount++;
		PickUpScore.text = "Score: " + pickUpCount.ToString ();
	}
}
