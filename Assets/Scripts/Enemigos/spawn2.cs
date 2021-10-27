using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn2 : MonoBehaviour 
{
	public GameObject prefab4;
	public GameObject prefab5;
	public GameObject prefab6;
	public GameObject prefab6_2;

	public float totalT;
	float timer1;
	float timer2;
	float valX;

	void Start () 
	{
		timer1 = 2;
		timer2 = 0;
		valX = -5.5f;
	}

	void Update ()
	{
		totalT += Time.deltaTime;

		if (totalT <= 10) {
			timer1 += Time.deltaTime;
			if (timer1 >= 4) {
				for (int i = 0; i <= 4; i++) {
					Instantiate (prefab4, new Vector3 (valX, 6.5f, 0), Quaternion.identity);
					valX = valX + 2.5f;
				}
				valX = -5.5f;
				timer1 = 0;
			}
		} else if (totalT > 10 && totalT <= 23) {
			timer1 = 0;
			timer2 += Time.deltaTime;
			if (timer2 >= 4) {
				Instantiate (prefab6, new Vector3 (-7.5f, 5.5f, 0), Quaternion.identity);
				timer2 = 0;
			}
		} else if (totalT > 27 && totalT <= 34) {
			timer2 = 0;
			timer1 += Time.deltaTime;
			if (timer1 >= 0.3f) {
				Vector3 position = new Vector3 (Random.Range (-8, 7), 6.5f, 0);
				Instantiate (prefab5, position, Quaternion.identity);
				timer1 = 0;
			}
		} else if (totalT > 32 && totalT <= 45) {
			timer1 = 0;
			timer2 += Time.deltaTime;
			if (timer2 >= 4) {
				Instantiate (prefab6_2, new Vector3 (7.5f, 5.5f, 0), Quaternion.identity);
				timer2 = 0;
			}
		} else if (totalT > 49) {
			timer2 = 0;
			totalT = 0;
		}
	}
}
