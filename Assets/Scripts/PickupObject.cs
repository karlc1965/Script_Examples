using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	GameObject mainCamera;
	bool carrying;
	GameObject carriedObject;
	public float distance;
	public float smooth;
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (carrying) {
			Carry (carriedObject);
			CheckDrop();
		} else {
			Pickup ();
		}
	}
	void RotateObject() {
		carriedObject.transform.Rotate (5, 10, 5);
	}

	void Carry(GameObject obj) {
		obj.transform.position = Vector3.Lerp(obj.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
		// stop picked up object rotating
		obj.transform.rotation = Quaternion.identity;
	}

	void Pickup() {
		if (Input.GetKeyDown (KeyCode.Q)) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				if( p != null) {
					carrying = true;
					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().useGravity = false;
				}
			}

		}
	}

	void CheckDrop() {
		if (Input.GetKeyDown (KeyCode.Q)) {
			DropObject();
		}
	}

	void DropObject() {
		carrying = false;
		carriedObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
	}
}
