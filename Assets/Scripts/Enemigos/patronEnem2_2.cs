using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patronEnem2_2 : MonoBehaviour 
{
	public GameObject iman;
	public GameObject barrera;
	public GameObject espada;
	public GameObject daga;
	public GameObject escudo;

	float vida = 1;
	float velocidadX = 0;
	float tiempo = 0;
	int drop = 0;

	Rigidbody Rigi;

	void Start () 
	{
		Rigi = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		eneMov ();

		if(vida <= 0)
		{
			Destroy(gameObject);
		}
	}

	void eneMov()
	{
		tiempo += Time.deltaTime;
		Rigi.velocity = new Vector3 (velocidadX, -9, 0);

		if(tiempo <= 0.5)
		{
			velocidadX = 5;
		}
		else if(tiempo > 0.5 && tiempo <= 1)
		{
			velocidadX = -5;
		}
		else if(tiempo > 1)
		{
			tiempo = 0;
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
		if (drop <= 10)
		{
			Instantiate (iman, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 10 && drop <= 20)
		{
			Instantiate (barrera, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 20 && drop <= 30)
		{
			Instantiate (espada, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 30 && drop <= 40)
		{
			Instantiate (daga, gameObject.transform.position, Quaternion.identity);
		}
		else if (drop > 40 && drop <= 50)
		{
			Instantiate (escudo, gameObject.transform.position, Quaternion.identity);
		}
		Destroy (gameObject);
	}
}
