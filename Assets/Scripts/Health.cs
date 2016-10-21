using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Health : MonoBehaviour {


/*	public float health = 100f;			 // Max health
	public float regeneration = 6f;		// Number is seconds for regen
	public float damage = 3f;			// Damage Number
	//public Slider healthSlider;
	//public Hunger hungerScript;
	private float timer;


	// Use this for initialization
	void start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		healthSlider.value = health;		// Health Goes down
		timer = Time.time;

		if (health < 0) health = 0;			// Health stays at 0

		if (hungerScript.hunger == 0) 		// If hungry
		{
			Invoke ("HealthRegen", regeneration);  // Regens health
		}

		// if at max health
		if (health >= 100) health = 100;	// Health max'ed at 100
	}

	void HealthRegen()
	{
		CancelInvoke ("HealthRegen");		// Cancels the timer
		health = health - damage;			//  Adjusts damage in the Inspector
	}
	*/
}