using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMovoment : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ringMotion.track&&ringMotion.track1) {
			transform.Translate (Vector3.left * Time.deltaTime/0.75f);
		}
	}
}
