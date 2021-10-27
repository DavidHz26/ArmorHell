using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLC : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(-0.2f, 1.0f, 0) * speed;

		Destroy (gameObject, 0.15f);
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
