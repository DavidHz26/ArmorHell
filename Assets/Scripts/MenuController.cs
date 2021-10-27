using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public GameObject Title;
	public GameObject anyKey;
	public GameObject HowTo;
	public GameObject Menu;
	public GameObject myCredits;
	public GameObject Levels;

	public GameObject Shine;

	public bool inMain;
	public bool inCred;
	public bool inInst;
	public bool inLevels;

	public float standby = 0.0f;

	// Use this for initialization
	void Start () {
		inMain = false;

	}
	
	// Update is called once per frame
	void Update () {

		standby += 0.05f;

		if (standby >= 0.0f && standby <= 1.5f) {
			Shine.SetActive (true);
		}

		if (standby >= 1.6 && standby <= 3.0f) {
			Shine.SetActive (false);
		}

		if (standby >= 3.1f) {
			standby = 0.0f;
		}

		if (Input.GetKey (KeyCode.A) && inMain == false) {
			Title.SetActive (false);
			anyKey.SetActive (false);
			HowTo.SetActive (false);
			Menu.SetActive (true);
			myCredits.SetActive (false);
			Levels.SetActive (false);
			inMain = true;
		}

		if (Input.GetKeyDown(KeyCode.Escape) && inMain == true) {
			Title.SetActive (true);
			anyKey.SetActive (true);
			HowTo.SetActive (false);
			Menu.SetActive (false);
			myCredits.SetActive (false);
			Levels.SetActive (false);
			inMain = false;
			inCred = false;
			inInst = false;

		}

		if (Input.GetKey(KeyCode.Escape) && inCred == true) {
			Title.SetActive (false);
			anyKey.SetActive (false);
			HowTo.SetActive (false);
			Menu.SetActive (true);
			myCredits.SetActive (false);
			Levels.SetActive (false);
			inMain = true;
			inCred = false;
			inInst = false;
		}	

		if (Input.GetKey(KeyCode.Escape) && inInst == true) {
			Title.SetActive (false);
			anyKey.SetActive (false);
			HowTo.SetActive (false);
			Menu.SetActive (true);
			myCredits.SetActive (false);
			Levels.SetActive (false);
			inMain = true;
			inCred = false;
			inInst = false;
		}	

		if (Input.GetKey(KeyCode.Escape) && inLevels == true) {
			Title.SetActive (false);
			anyKey.SetActive (false);
			HowTo.SetActive (false);
			Menu.SetActive (true);
			myCredits.SetActive (false);
			Levels.SetActive (false);
			inMain = true;
			inCred = false;
			inInst = false;
			inLevels = false;
		}	



	}

	public void Play() {
		SceneManager.LoadScene ("Nivel_1");
	}

	public void fLevel() {
		Title.SetActive (false);
		anyKey.SetActive (false);
		HowTo.SetActive (false);
		Menu.SetActive (false);
		myCredits.SetActive (false);
		Levels.SetActive (true);
		inMain = false;
		inCred = false;
		inInst = false;
		inLevels = true;
	}

	public void Credits() {
		Title.SetActive (false);
		anyKey.SetActive (false);
		HowTo.SetActive (false);
		Menu.SetActive (false);
		myCredits.SetActive (true);
		inMain = false;
		inCred = true;
		inInst = false;
		inLevels = false;
	}

	public void Instructions() {
		Title.SetActive (false);
		anyKey.SetActive (false);
		HowTo.SetActive (true);
		Menu.SetActive (false);
		myCredits.SetActive (false);
		inMain = false;
		inCred = false;
		inInst = true;
		inLevels = false;
		
	}

	public void Exit() {
		Application.Quit ();
	}
		
}
