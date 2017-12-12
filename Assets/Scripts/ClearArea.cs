using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

	private float timeSinceLastTrigger = 0f;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerStay()
	{		
		timeSinceLastTrigger = 0f;
	}
	// Update is called once per frame
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;
		if (timeSinceLastTrigger>=1f&&Time.realtimeSinceStartup>10f) {
			SendMessageUpwards ("OnFindClearArea");
		}
	}
}
