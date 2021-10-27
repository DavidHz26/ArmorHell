using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

	public GameObject scrPlayer;
	List<GameObject> follow; 
	public float speed;

	// Use this for initialization
	void Start () {
		scrPlayer = GameObject.FindWithTag ("Player");
		follow = scrPlayer.GetComponent<PlayerController> ().Followers;
		follow.Add (this.gameObject);

	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

	void OnTriggerEnter (Collider _col){
		if (_col.gameObject.CompareTag ("Player")) {
			follow.Remove (this.gameObject);
			Destroy (gameObject);
		}

		if (_col.gameObject.CompareTag ("pader")) {
			follow.Remove (this.gameObject);
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
