using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponShot : MonoBehaviour {

	public GameObject Bullet1;
	public GameObject Bullet2_1;
	public GameObject Bullet2_2;
	public GameObject Bullet3_1;
	public GameObject Bullet3_2;
	public GameObject Bullet3_3;

	public GameObject Ulti1;
	public GameObject Ulti2;
	public GameObject Ulti3;

	public GameObject Player;
	public int numWeapon;

	public Transform shotSpawn1;
	public Transform shotSpawn2;
	public Transform shotSpawn3;
	public Transform shotSpawn4;
	public Transform shotSpawn5;
	public Transform ulti2Spawn;

	public float Ultimate;
	public float tmpUlti;

	public int _lvWeapon1;
	public int _lvWeapon2;
	public int _lvWeapon3;

	public float cadencia1;
	float cd1;
	public float cadencia2;
	float cd2;
	public float cadencia3;
	float cd3;

	public Image UltiBar;
	public float maxEnergy;
	public float curEnergy;

	// Use this for initialization
	void Start () {
		numWeapon = Player.GetComponent<LevelUpController> ().Weapon;
		_lvWeapon1 = Player.GetComponent<LevelUpController> ().lvWeapon1;
		_lvWeapon2 = Player.GetComponent<LevelUpController> ().lvWeapon2;
		_lvWeapon3 = Player.GetComponent<LevelUpController> ().lvWeapon3;

		tmpUlti = Ultimate;
	
		cd1 = cadencia1;
		cd2 = cadencia2;
		cd3 = cadencia3;

		curEnergy = maxEnergy;
	}
	
	// Update is called once per frame
	void Update () {

		_lvWeapon1 = Player.GetComponent<LevelUpController> ().lvWeapon1;
		_lvWeapon2 = Player.GetComponent<LevelUpController> ().lvWeapon2;
		_lvWeapon3 = Player.GetComponent<LevelUpController> ().lvWeapon3;

		Ultimate -= Time.deltaTime;
		cadencia1 -= Time.deltaTime;
		cadencia2 -= Time.deltaTime;
		cadencia3 -= Time.deltaTime;

		///Nivel Weapon 1

		if (_lvWeapon1 <= 1) {
			cd1 = 0.3f;
		}
		if (_lvWeapon1 == 2 || _lvWeapon1 == 3) {
			cd1 = 0.1f;
		}
		if (_lvWeapon1 >= 4) {
			cd1 = 0.0f;
		}

		///Nivel Weapon 2

		if (_lvWeapon2 <= 4) {
			cd2 = 0.4f;
		}
		if (_lvWeapon2 == 5 || _lvWeapon2 == 6) {
			cd2 = 0.2f;
		}
		if (_lvWeapon2 >= 7) {
			cd2 = 0.0f;
		}

		///Nivel Weapon 3

		if (_lvWeapon3 <= 4) {
			cd3 = 0.8f;
		}
		if (_lvWeapon3 == 5 || _lvWeapon3 == 6) {
			cd3 = 0.4f;
		}
		if (_lvWeapon3 >= 7) {
			cd3 = 0.0f;
		}

		///Ultimate Bar
		if (Ultimate <= 10 && Ultimate >= 9.1f) {
			UltiBar.fillAmount = 0.0f;
		} else if (Ultimate <= 9 && Ultimate >= 8.1f) {
			UltiBar.fillAmount = 0.1f;
		} else if (Ultimate <= 8 && Ultimate >= 7.1f) {
			UltiBar.fillAmount = 0.2f;
		} else if (Ultimate <= 7 && Ultimate >= 6.1f) {
			UltiBar.fillAmount = 0.3f;
		} else if (Ultimate <= 6 && Ultimate >= 5.1f) {
			UltiBar.fillAmount = 0.4f;
		} else if (Ultimate <= 5 && Ultimate >= 4.1f) {
			UltiBar.fillAmount = 0.5f;
		} else if (Ultimate <= 4 && Ultimate >= 3.1f) {
			UltiBar.fillAmount = 0.6f;
		} else if (Ultimate <= 3 && Ultimate >= 2.1f) {
			UltiBar.fillAmount = 0.7f;
		} else if (Ultimate <= 2 && Ultimate >= 1.1f) {
			UltiBar.fillAmount = 0.8f;
		} else if (Ultimate <= 1 && Ultimate >= 0.1f) {
			UltiBar.fillAmount = 0.9f;
		} else if (Ultimate <= 0) {
			UltiBar.fillAmount = 1.0f;
		}

		///Disparos
	
		if (Input.GetKey (KeyCode.Space) && numWeapon == 1 && cadencia1 <= 0) {
			Instantiate (Bullet1, shotSpawn3.position, shotSpawn3.rotation);
			cadencia1 = cd1;
		}

		if (Input.GetKey (KeyCode.Space) && numWeapon == 2 && cadencia2 <= 0) {				
			Instantiate (Bullet2_1, shotSpawn1.position, Quaternion.identity);
			Instantiate (Bullet2_2, shotSpawn2.position, Quaternion.identity);
			cadencia2 = cd2;
		}

		if (Input.GetKey (KeyCode.Space) && numWeapon == 3 && cadencia3 <= 0)
		{
			Instantiate (Bullet3_1, shotSpawn5.position, shotSpawn5.rotation);
			Instantiate (Bullet3_2, shotSpawn3.position, shotSpawn3.rotation);				
			Instantiate (Bullet3_3, shotSpawn4.position, shotSpawn4.rotation);
			cadencia3 = cd3;
		}

		if (Input.GetKey(KeyCode.K) && Ultimate <= 0.0f) {

			if (numWeapon == 1) {
				Instantiate (Ulti1, shotSpawn3.position, shotSpawn3.rotation);
				if (Ultimate <= -10.0f) {
					Ultimate = tmpUlti;
				}
			}

			if (numWeapon == 2) {
				Instantiate (Ulti2, ulti2Spawn.position, ulti2Spawn.rotation);
				Ultimate = tmpUlti;
			}

			/*if (numWeapon == 3)
			{
				Ulti3.SetActive (true);
				Ultimate = tmpUlti;
			}*/
		}
	}
}
