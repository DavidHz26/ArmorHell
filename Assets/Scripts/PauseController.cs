using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

	public GameObject pMenu;
	public bool onMenu = false;
	public GameObject Player;

	public GameObject btnSword;
	public GameObject btnShield;
	public GameObject btnDagger;

	public GameObject btnMagnet;
	public GameObject btnpuShield;

	public GameObject NoSword;
	public GameObject NoShield;
	public GameObject NoDagger;

	public GameObject NoMagnet;
	public GameObject NopuShield;

	public bool Sword = true;
	public bool Shield;
	public bool Dagger;

	public bool Magnet;
	public bool puShield;

	//DESCRIPTIONS
	public GameObject descSword;
	public GameObject descShield;
	public GameObject descDagger;
	public GameObject descpuShield;
	public GameObject descMagnet;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	

		if (Input.GetKeyDown (KeyCode.Escape) && onMenu == false) {
			pMenu.SetActive (true);
			onMenu = true;
			Time.timeScale = 0.0f;
		}

		else if (Input.GetKeyDown (KeyCode.Escape) && onMenu == true) {
			pMenu.SetActive (false);
			onMenu = false;
			Time.timeScale = 1.0f;
		}

		if (Sword == true) {
			NoSword.SetActive (false);
			btnSword.SetActive (true);
		}
		if (Shield == true) {
			NoShield.SetActive (false);
			btnShield.SetActive (true);
		}
		if (Dagger == true) {
			NoDagger.SetActive (false);
			btnDagger.SetActive (true);
		}
		if (Magnet == true) {
			NoMagnet.SetActive (false);
			btnMagnet.SetActive (true);
		}
		if (puShield == true) {
			NopuShield.SetActive (false);
			btnpuShield.SetActive (true);
		}
	}

	public void onSword () {
		descSword.SetActive (true);
	}

	public void onShield () {
		descShield.SetActive (true);
	}

	public void onDagger () {
		descDagger.SetActive (true);
	}
	public void onBarrier () {
		descpuShield.SetActive (true);
	}
	public void onMagnet () {
		descMagnet.SetActive (true);
	}

	public void close () {
		descSword.SetActive (false);
		descShield.SetActive (false);
		descDagger.SetActive (false);
		descpuShield.SetActive (false);
		descMagnet.SetActive (false);
	}

	public void Continue (){
		pMenu.SetActive (false);
		Time.timeScale = 1.0f;
	}

	public void mMenu (){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1.0f;
	}

	public void Exit(){
		Application.Quit ();
	}


}
