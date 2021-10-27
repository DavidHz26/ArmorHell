using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOController : MonoBehaviour {

	public GameObject H;
	public GameObject A;
	public GameObject Z;

	public GameObject M;
	public GameObject U;
	public GameObject E;
	public GameObject R;
	public GameObject T;
	public GameObject O;
	public GameObject Sym;


	public GameObject Retry;
	public GameObject Exit;

	public float temp;

	// Use this for initialization
	void Start () {
		temp = 0.0f;

	/*	Y.SetActive (false);
		O.SetActive (false);
		U.SetActive (false);

		D.SetActive (false);
		I.SetActive (false);
		E.SetActive (false);
		D2.SetActive (false);
		Sym.SetActive (false);

		Retry.SetActive (false);
		Exit.SetActive (false);*/
		
	}
	
	// Update is called once per frame
	void Update () {
		temp += 0.1f;


		if (temp >= 1.0f) {
			H.SetActive (true);
		}

		if (temp >= 2.0f) {
			A.SetActive (true);
		}

		if (temp >= 3.0f) {
			Z.SetActive (true);
		}

		if (temp >= 4.0f) {
			M.SetActive (true);
		}

		if (temp >= 5.0f) {
			U.SetActive (true);
		}

		if (temp >= 6.0f) {
			E.SetActive (true);
		}

		if (temp >= 7.0f) {
			R.SetActive (true);
		}

		if (temp >= 8.0) {
			T.SetActive (true);
		}

		if (temp >= 9.0) {
			O.SetActive (true);
		}

		if (temp >= 10.0) {
			Sym.SetActive (true);
		}

		if (temp >= 16.0f) {
			Retry.SetActive (true);
			Exit.SetActive (true);
		}

		if (temp >= 16.1f) {
			temp = 16.1f;
		}

	}


	public void mMenu(){
		SceneManager.LoadScene ("Menu");
	}

	public void _Retry (){
		SceneManager.LoadScene ("Nivel_1");
	}
}
