using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossHealth : MonoBehaviour {

	public float currentHealth {get; set; }
	public float MaxHealth {get; set; }
	public Slider HealthBar;


	// Use this for initialization
	void Start () {
		MaxHealth = 20.0f;

		currentHealth = MaxHealth;
		HealthBar.value = CalculateHealth();
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Bullet"){
			Object.Destroy(col.gameObject);
			DealDamage(3);
		}
	}
    //Deal damage to the boss
	void DealDamage(int DamageDealth){
		currentHealth -= DamageDealth;
		HealthBar.value = CalculateHealth();

		if(currentHealth <= 0){
			//Destroy(this.gameObject);
			Die();
			ScoreScript.scoreVal += 10;
		}
	}
    //divide currentHealth by MAxhealth for the healthslider
	float CalculateHealth(){
		return currentHealth / MaxHealth;
	}

	void Die(){
          Destroy(this.gameObject);
		  currentHealth = 0;
	}
}
