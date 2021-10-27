using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PatronJefe : MonoBehaviour 
{
	Animator anim;
	Rigidbody Rigi;

	public float vida = 450;

	void Start () 
	{
		anim = GetComponent<Animator>();
		Rigi = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		if(vida <= 0)
		{
			anim.SetBool ("muerte", true);
			SceneManager.LoadScene ("Victory");
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.CompareTag("bala"))
		{
			vida--;
		}
		if(col.gameObject.CompareTag("ulti1"))
		{
			vida -= 2;
		}
		if(col.gameObject.CompareTag("ulti2"))
		{
			vida -= 30;
		}
	}
}
