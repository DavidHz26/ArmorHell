using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	public int hearts;
	public float heartUp;
	public float CdShield;
	public float CdMagnet;
	public bool activeShield;
	public bool activeMagnet;

	public GameObject Shield;
	public List<GameObject> Followers;

	public int Weapon = 1;
	public GameObject Weapon1;
	public GameObject Weapon2;
	public GameObject Weapon3;
	public GameObject bala;

	Animator anim;

	public GameObject Inventory;

	public bool sword = false;
	public bool dagger = false;
	public bool shield = false;
	public bool magnet = false;
	public bool pushield = false;

	public Text txtHearts;
	public float Score;
	public Text txScore;

	public GameObject spaun1;
	public GameObject spaun2;
	public GameObject spaun3;

	public GameObject fondo1;
	public GameObject fondo2;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();


	}
	
	// Update is called once per frame
	void Update () {
		Inventory.GetComponent<PauseController> ().Sword = sword;
		Inventory.GetComponent<PauseController> ().Shield = shield;
		Inventory.GetComponent<PauseController> ().Dagger = dagger;
		Inventory.GetComponent<PauseController> ().Magnet = magnet;
		Inventory.GetComponent<PauseController> ().puShield = pushield;

		///Interfaz
		txtHearts.text = "x " + hearts as string; 
		Score += 1.0f * Time.deltaTime;
		txScore.text = "SCORE: " + Mathf.RoundToInt(Score) as string;

		if(Score <= 50)
		{
			spaun1.SetActive (true);
			spaun2.SetActive (false);
			spaun3.SetActive (false);
			fondo1.SetActive (true);
			fondo2.SetActive (false);
		}
		else if(Score > 50 && Score <= 100)
		{
			spaun1.SetActive (false);
			spaun2.SetActive (true);
			spaun3.SetActive (false);
		}
		else if(Score > 100)
		{
			spaun1.SetActive (false);
			spaun2.SetActive (false);
			spaun3.SetActive (true);
			fondo1.SetActive (false);
			fondo2.SetActive (true);
		}

		if (transform.position.y <= -3.75f) 
		{
			transform.position = new Vector3 (transform.position.x, -3.69f, transform.position.z);
		}
		else if(transform.position.y >= 5.6f)
		{
			transform.position = new Vector3 (transform.position.x, 5.5f, transform.position.z);
		}

		if(transform.position.x <= -6.26f)
		{
			transform.position = new Vector3 (-6.25f, transform.position.y, transform.position.z);
		}
		else if(transform.position.x >= 6.26f)
		{
			transform.position = new Vector3 (6.25f, transform.position.y, transform.position.z);
		}
			
		if (transform.position.z != 0) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
		}

		///TECLADO

		anim.SetBool ("Idle", true);

		heartUp += Time.deltaTime;
		CdShield += Time.deltaTime;
		CdMagnet += Time.deltaTime;


		if (heartUp > 50) {
			hearts += 1;
			heartUp = 0;
		}

		if (hearts > 5) {
			hearts = 5;
		}

		///Movimiento

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
			anim.SetBool ("Up", true);
		} else {
			anim.SetBool ("Up", false);
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
			anim.SetBool ("Right", true);
		} else {
			anim.SetBool ("Right", false);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
			anim.SetBool ("Left", true);
		} else {
			anim.SetBool ("Left", false);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
			anim.SetBool ("Down", true);
		} else {
			anim.SetBool ("Down", false);
		}
			
		///Cooldowns
			
		if (CdShield >= 3.0f) {
			Shield.SetActive (false);
			activeShield = false;
		}

		if (CdMagnet >= 5.0f) {
			activeMagnet = false;
		}

		///Armas

		if (Weapon == 1) {
			Weapon1.SetActive (true);
			Weapon2.SetActive (false);
			Weapon3.SetActive (false);
		}

		if (Weapon == 2) {
			Weapon1.SetActive (false);
			Weapon2.SetActive (true);
			Weapon3.SetActive (false);
		}

		if (Weapon == 3) {
			Weapon1.SetActive (false);
			Weapon2.SetActive (false);
			Weapon3.SetActive (true);
		}

		if(activeMagnet == false){
			Desactivate ();
		}

		///CONTROL


		///Movimiento

		float xAxis = Input.GetAxis ("JsHorizontal");
		float yAxis = Input.GetAxis ("JsVertical");

		if (xAxis < 0) {
			transform.position += Vector3.left * speed;
			anim.SetBool ("Right", true);
		} else {
			anim.SetBool ("Right", false);
		}

		if (xAxis > 0) {
			transform.position += Vector3.right * speed;
			anim.SetBool ("Left", true);
		} else {
			anim.SetBool ("Left", false);
		}

		if(yAxis > 0) {
			transform.position += Vector3.down * speed;
			anim.SetBool ("Down", true);
		} else {
			anim.SetBool ("Down", false);
		}

		if(yAxis < 0){
			transform.position += Vector3.up * speed; 
			anim.SetBool ("Up", true);
		} else {
			anim.SetBool ("Up", false);
		}
		
}

	void OnCollisionEnter(Collision _col){
		if (_col.gameObject.CompareTag ("pader")) {
			print ("Tocando limites");

		}

	}

	void OnTriggerEnter(Collider _col){
		if(_col.gameObject.CompareTag("shield")){
			activeShield = true;
			CdShield = 0;
			Shield.SetActive (true);
			pushield = true;
		}

		if (_col.gameObject.CompareTag ("magnet")) {
			activeMagnet = true;
			CdMagnet = 0;
			magnet = true;
		}

		if (activeMagnet == true) {
			Activate ();
		} 

		if(_col.gameObject.CompareTag("Weapon")){
			Weapon = 1;
			sword = true;
		}

		if(_col.gameObject.CompareTag("Weapon+")){
			Weapon = 2;
			dagger = true;
		}

		if(_col.gameObject.CompareTag("Weapon++")){
			Weapon = 3;
			shield = true;
		}

		if(_col.gameObject.CompareTag("balin")){
			Morir ();
		}

		if (_col.gameObject.CompareTag ("enem1")) {
			Morir ();
		}

		if (_col.gameObject.CompareTag ("suicida")) {
			Morir ();
		}
	}

	void Activate(){
		for (int i = 0; i < Followers.Count; i++) {
			GameObject go = Followers [i];
			go.GetComponent<actvMagnet> ().enabled = true;
		}
	}

	void Desactivate (){
		for (int i = 0; i < Followers.Count; i++) {
			GameObject go = Followers [i];
			go.GetComponent<actvMagnet> ().enabled = false;
		}
	}

	void Morir(){
		if (activeShield == false) {

			if (hearts > 0) {
				transform.position = new Vector3 (0, -2, 0);
				hearts -= 1;

				activeShield = true;
				CdShield = 0;
				Shield.SetActive (true);

			} else {
				SceneManager.LoadScene ("GameOver");

			}
		}
	}
}
