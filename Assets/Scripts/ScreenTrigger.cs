using UnityEngine;
using System.Collections;

public class ScreenTrigger : MonoBehaviour {


	void OnTriggerEnter (Collider ball) {
		if(ball.tag == "Ball") {
			print ("OI Ball");
			Destroy (ball.gameObject);
			NotificationCenter.DefaultCenter.PostNotification(this, "BallFire");
		}
	}
}
