using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour 
{
	public GameObject prefab1;
	public GameObject prefab1_2;
	public GameObject prefab1_3;
	public GameObject prefab1_4;
	public GameObject prefab2;
	public GameObject prefab3;

	public float totalT = 0;
	float timer1 = 0;
	float timer2 = 0;

	void Update()
	{
		totalT += Time.deltaTime;

		if (totalT <= 7) 
		{
			timer1 += Time.deltaTime;
			if (timer1 >= 0.5) 
			{
				Vector3 position = new Vector3 (Random.Range(-8.7f, -7.0f), 6.3f, 0);
				Instantiate (prefab1, position, Quaternion.identity);
				timer1 = 0;
			}
		} 
		else if (totalT > 9 && totalT <= 16) 
		{
			timer1 = 0;
			timer2 += Time.deltaTime;
			if (timer2 >= 0.5) 
			{
				Vector3 position = new Vector3 (Random.Range(7.0f, 8.7f), 6.3f, 0);
				Instantiate (prefab1_2, position, Quaternion.identity);
				timer2 = 0;
			}
		} 
		else if (totalT >= 16 && totalT <= 27) 
		{
			timer2 = 0;
			timer1 += Time.deltaTime;
			if (timer1 >= 1) 
			{
				Vector3 position = new Vector3 (-8.0f, Random.Range (4.5f, 5.0f), 0);
				Instantiate (prefab3, position, Quaternion.identity);
				timer1 = 0;
			}
		} 
		else if (totalT >= 27 && totalT <= 34) 
		{
			timer1 = 0;
			timer2 += Time.deltaTime;
			if (timer2 >= 1) 
			{
				Vector3 position = new Vector3 (8, 3, 0);
				Instantiate (prefab1_3, position, Quaternion.identity);
				timer2 = 0;
			}
		} 
		else if (totalT > 34 && totalT <= 41) 
		{
			timer2 = 0;
			timer1 += Time.deltaTime;
			if (timer1 >= 1) 
			{
				Vector3 position = new Vector3 (-8, 4.7f, 0);
				Instantiate (prefab1_4, position, Quaternion.identity);
				timer1 = 0;
			}
		} 
		else if (totalT > 41 && totalT <= 47) 
		{
			timer1 = 0;
			timer2 += Time.deltaTime;
			if (timer2 >= 0.2f) 
			{
				Vector3 position = new Vector3 (Random.Range (-8, 8), 6.5f, 0);
				Instantiate (prefab2, position, Quaternion.identity);
				timer2 = 0;
			}
		} 
		else if (totalT > 49) 
		{
			timer2 = 0;
			totalT = 0;
		}
	}
}
