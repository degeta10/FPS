using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public AudioClip audioclip;

	private bool call = false;
	private AudioSource audiosource;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody> ();
	}

	public void Call()	{
		if (!call) {
			call = true;
			Debug.Log ("Helicopter Called");
			audiosource.clip = audioclip;
			audiosource.Play ();
			rb.velocity = new Vector3 (0,0,50f);
		}
	}
}
