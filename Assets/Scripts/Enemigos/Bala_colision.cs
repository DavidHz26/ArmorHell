using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_colision : MonoBehaviour 
{
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.CompareTag("pader"))
		{
			Destroy (gameObject);
		}
		if(col.gameObject.CompareTag("Player"))
		{
			Destroy (gameObject);
		}
		if(col.gameObject.CompareTag("ulti3"))
		{
			Destroy (gameObject);
		}
	}
}
