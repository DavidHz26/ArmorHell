using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ulti3 : MonoBehaviour {

	public GameObject Player;
	public float temp = 4.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		temp -= Time.deltaTime;

		if (temp <= 0.0f) {
			gameObject.SetActive (false);
			temp = 4.0f;
		}
	}
}
