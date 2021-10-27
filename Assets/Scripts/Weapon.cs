using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider _col){
		if (_col.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		}

		if (_col.gameObject.CompareTag ("pader")) {
			Destroy (gameObject);
		}

		if (_col.gameObject.CompareTag ("ulti1")) {
			Destroy (gameObject);
		}

		if (_col.gameObject.CompareTag ("ulti2")) {
			Destroy (gameObject);
		}

		if (_col.gameObject.CompareTag ("ulti3")) {
			Destroy (gameObject);
		}
	}
		
}
