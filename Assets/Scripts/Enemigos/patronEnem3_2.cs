using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patronEnem3_2 : MonoBehaviour 
{
	public GameObject iman;
	public GameObject barrera;
	public GameObject espada;
	public GameObject daga;
	public GameObject escudo;

	float vida = 10;
	float velocidadX = 10;
	int drop = 0;

	Rigidbody Rigi;

	void Start () 
	{
		Rigi = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		Rigi.velocity = new Vector3 (velocidadX, 0, 0);

		if(vida <= 0)
		{
			soltarObj ();
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
			soltarObj();
		}
		if(col.gameObject.CompareTag("Player"))
		{
			Destroy (gameObject);
		}
		if(col.gameObject.CompareTag("bala"))
		{
			vida--;
		}
		if(col.gameObject.CompareTag("ulti1"))
		{
			vida -= 5;
		}
		if(col.gameObject.CompareTag("ulti2"))
		{
			vida -= 10;
		}
		if(col.gameObject.CompareTag("ulti3"))
		{
			Destroy (gameObject);
		}
	}

	void soltarObj()
	{
		drop = Random.Range (1, 100);
		if (drop <= 20)
		{
			Instantiate (iman, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 20 && drop <= 40)
		{
			Instantiate (barrera, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 40 && drop <= 60)
		{
			Instantiate (espada, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 60 && drop <= 80)
		{
			Instantiate (daga, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 80 && drop <= 100)
		{
			Instantiate (escudo, gameObject.transform.position, Quaternion.identity);
		}
		Destroy (gameObject);
	}
}
