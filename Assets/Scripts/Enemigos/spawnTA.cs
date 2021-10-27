using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTA : MonoBehaviour 
{
	public GameObject prefab2;
	float timer = 0;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		timer += Time.deltaTime;

		if(timer >= 5)
		{
			Vector3 position = new Vector3 (Random.Range (-6.0f, 6.0f), 7, 0);
			Instantiate (prefab2, position, Quaternion.identity);
			timer = 0;
		}
	}
}
