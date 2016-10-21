using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float health = 100f;			 // Max health
	public float regeneration = 6f;		// Number is seconds for regen
	public float damage = 3f;			// Damage Number
	public Slider healthSlider;
	public GameObject slider;
	//public Hunger hungerScript;
	private float timer;
	public Image death;
	public Text deathText;
	float fadeTime = 3.0f;
	Color colorFadeTo;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// allways update health slider
		healthSlider.value = health;
		if (health <= 0f) {
			// crossfadealpha controls alpha channel opacity over duration
			death.CrossFadeAlpha (255f, 0.3f, false);
			slider.SetActive(false);
			deathText.CrossFadeAlpha (255f, 8f, false);
			Invoke ("ResetLevel", 3f);
		}
	}

	void OnCollisionEnter(Collision bullet) {

		if (bullet.gameObject.tag == "Bullet") {
			//Debug.Log ("I am hit!!!!!");
			health -= damage;
		}
	}

	void ResetLevel() {
		Application.LoadLevel ("Script_Examples_001");
	}
}
