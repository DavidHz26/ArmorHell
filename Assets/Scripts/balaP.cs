using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaP : MonoBehaviour 
{
	Rigidbody Rigi;

	float vida = 0;

	void Start () 
	{
		Rigi = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		Rigi.velocity = new Vector3 (0, 10, 0);

		vida += Time.deltaTime;

		if(vida >= 2)
		{
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.CompareTag("pader"))
		{
			Destroy (gameObject);
		}

		if(col.gameObject.CompareTag("suicida"))
		{
			Destroy (gameObject);
		}

		if(col.gameObject.CompareTag("enem1"))
		{
			Destroy (gameObject);
		}
	}
}
