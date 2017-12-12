using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform SpawnPoints;
	public bool Respawn=false;
	public Helicopter heli;

	private Transform[] spawnpoints;
	private bool toggle = false;

	void Start () {
		spawnpoints = SpawnPoints.GetComponentsInChildren<Transform> ();
	}
	
	private void ReSpawn()
	{
		int i = Random.Range (1,spawnpoints.Length);
		transform.position = spawnpoints [i].transform.position;
	}

	void OnFindClearArea()
	{		
		heli.Call ();
	}

	void Update () 
	{
		if (toggle != Respawn) {
			ReSpawn ();
			Respawn = false;
		} else {
			toggle = Respawn;
		}
	}
}
