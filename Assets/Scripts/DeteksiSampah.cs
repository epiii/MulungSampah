using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour {

	public string nameTag;
	public AudioClip audioBenar;
	public AudioClip audioSalah;
	private AudioSource MediaPlayerBenar;
	private AudioSource MediaPlayerSalah;
	public Text TextScore;

	// Use this for initialization
	private void Start () {
		MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		MediaPlayerBenar.clip = audioBenar;

		MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
		MediaPlayerSalah.clip = audioSalah;
	}
	
	private void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals(nameTag)){
		Debug.Log("masuk bener");
			Data.score+=25;
			TextScore.text=Data.score.ToString();
			Destroy(other.gameObject);
			MediaPlayerBenar.Play();
		}else{
		Debug.Log("masuksalah");
			Data.score-=5;
			TextScore.text=Data.score.ToString();
			Destroy(other.gameObject);
			MediaPlayerSalah.Play();
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
