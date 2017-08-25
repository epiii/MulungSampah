using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other){
		Destroy(other.gameObject);
		SceneManager.LoadScene("Gameover",LoadSceneMode.Single);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
