﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour {

	float timer;
	public float jeda = 0.8f;
	public GameObject[] objekSampah;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer+=Time.deltaTime;
		if(timer > jeda){
			int random = Random.Range(0, objekSampah.Length);
			Instantiate(objekSampah[random],transform.position, transform.rotation);
			timer = 0;
		}
		
	}
}
