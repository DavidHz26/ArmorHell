using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn3 : MonoBehaviour 
{
	public GameObject prefab7;
	public GameObject prefab8;
	public GameObject prefab9;
	public GameObject jefe;

	float timer1;
	float timer2;
	float timer3;

	void Start () 
	{
		timer1 = 5;
		timer2 = 4;
		timer3 = 0; 

		Instantiate (jefe, new Vector3 (0, 4, 0), Quaternion.identity);
	}

	void Update () 
	{
		timer1 += Time.deltaTime;
		timer2 += Time.deltaTime;

		if (timer1 >= 15) 
		{
			Instantiate (prefab7, new Vector3 (-5.5f, 6, 0), Quaternion.identity);
			timer1 = 0;
		}

		if (timer2 >= 18) 
		{
			Instantiate (prefab9, new Vector3 (5.5f, 6, 0), Quaternion.identity);
			timer2 = 0;
		}
		if (timer3 >= 8) 
		{
			Instantiate (prefab8, new Vector3 (-7.5f, Random.Range (-3, 2), 0), Quaternion.identity);
			timer3 = 0;
		}
	}
}
