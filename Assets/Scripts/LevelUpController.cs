using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpController : MonoBehaviour {

	public GameObject Weapon1;
	public GameObject Weapon2;
	public GameObject Weapon3;

	public int Weapon = 1;

	public float tmp;
	public bool powerUP = true;

	public int lvWeapon1 = 1;
	public int lvWeapon2 = 0;
	public int lvWeapon3 = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		tmp -= Time.deltaTime;

		if (tmp <= 0.0) {
			powerUP = true;
		}

		if (Weapon == 1) {
			Weapon1.SetActive (true);
			Weapon2.SetActive (false);
			Weapon3.SetActive (false);
		}

		if (Weapon == 2) {
			Weapon1.SetActive (false);
			Weapon2.SetActive (true);
			Weapon3.SetActive (false);
		}

		if (Weapon == 3) {
			Weapon1.SetActive (false);
			Weapon2.SetActive (false);
			Weapon3.SetActive (true);
		}
			
	}

	void OnTriggerEnter(Collider _col){
		if(_col.gameObject.CompareTag("Weapon") && powerUP == true){
			Weapon = 1;
			powerUP = false;
			lvWeapon1 += 1;
			if (lvWeapon1 >= 5) {
				lvWeapon1 = 5;
			}
		}

		if(_col.gameObject.CompareTag("Weapon+") && powerUP == true){
			Weapon = 2;
			powerUP = false;
			lvWeapon2 += 1;
			if (lvWeapon2 >= 7) {
				lvWeapon2 = 7;
			}
		}
		
		if(_col.gameObject.CompareTag("Weapon++") && powerUP == true){
			Weapon = 3;
			powerUP = false;
			lvWeapon3 += 1;
			if (lvWeapon3 >= 7) {
				lvWeapon3 = 7;
			}
		}


	}
}
