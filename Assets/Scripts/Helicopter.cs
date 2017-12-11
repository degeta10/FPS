using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public AudioClip audioclip;

	private bool call = false;
	private AudioSource audiosource;
	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("CallHeli")&& call==false) {
			call = true;
			Debug.Log ("Helicopter Called");
			audiosource.clip = audioclip;
			audiosource.Play ();
		}
	}
}
