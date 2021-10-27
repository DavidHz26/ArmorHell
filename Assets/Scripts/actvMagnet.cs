using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actvMagnet : MonoBehaviour {

	public GameObject Player;
	public float Speed;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, Player.transform.position, Speed * Time.deltaTime);
		Debug.DrawLine (transform.position, Player.transform.position, Color.green);
	}
}
