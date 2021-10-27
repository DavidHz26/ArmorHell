using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

	public float Speed1;
	public float Speed2;
	public float Speed3;

	public GameObject Player;
	public int numWeapon;

	// Use this for initialization
	void Start () {
		numWeapon = Player.GetComponent<LevelUpController> ().Weapon;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (numWeapon == 1) {
			transform.position += Vector3.up * Speed1;
		}

		if (numWeapon == 2) {
			transform.position += Vector3.up * Speed2;
		}

		if (numWeapon == 3) {
			transform.position += Vector3.up * Speed3;
		}

		Destroy (gameObject, 0.5f);
	}

	void OnTriggerEnter(Collider _col){
		if (_col.gameObject.CompareTag ("pader")) {
			Destroy (gameObject);
		}

		if (_col.gameObject.CompareTag ("enem1")) {
			Destroy (gameObject);
		}
	}
}
