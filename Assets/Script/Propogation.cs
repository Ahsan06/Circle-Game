using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propogation : MonoBehaviour {

	public GameObject[] Paths;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ringMotion.propoControl) {
			if (ringMotion.pathIdentifier == 0) {
			int asa;
			asa = Random.Range (0, 4);
				if (asa == 0) {
					Paths [2].transform.localPosition = new Vector3 (Paths [0].transform.localPosition.x + 16.4309f, Paths [0].transform.localPosition.y, Paths [0].transform.localPosition.z);
					ringMotion.propoControl = false;
				} else {
					Paths [asa].transform.localPosition = new Vector3 (Paths [0].transform.localPosition.x + 16.4309f, Paths [0].transform.localPosition.y, Paths [0].transform.localPosition.z);
					ringMotion.propoControl = false;
				}
		
				
			}
			if (ringMotion.pathIdentifier == 1) {
				int asa;
				asa = Random.Range (0, 4);
				if (asa == 1) {
					Paths [3].transform.localPosition = new Vector3 (Paths [1].transform.localPosition.x + 16.4309f, Paths [1].transform.localPosition.y, Paths [1].transform.localPosition.z);
					ringMotion.propoControl = false;
				} else {
					Paths [asa].transform.localPosition = new Vector3 (Paths [1].transform.localPosition.x + 16.4309f, Paths [1].transform.localPosition.y, Paths [1].transform.localPosition.z);
					ringMotion.propoControl = false;
				}


			}
			if (ringMotion.pathIdentifier == 2) {
				int asa;
				asa = Random.Range (0, 4);
				if (asa == 2) {
					Paths [1].transform.localPosition = new Vector3 (Paths [2].transform.localPosition.x + 16.4309f, Paths [2].transform.localPosition.y, Paths [2].transform.localPosition.z);
					ringMotion.propoControl = false;
				} else {
					Paths [asa].transform.localPosition = new Vector3 (Paths [2].transform.localPosition.x + 16.4309f, Paths [2].transform.localPosition.y, Paths [2].transform.localPosition.z);
					ringMotion.propoControl = false;
				}


			}
			if (ringMotion.pathIdentifier == 3) {
				int asa;
				asa = Random.Range (0, 4);
				if (asa == 3) {
					Paths [0].transform.localPosition = new Vector3 (Paths [3].transform.localPosition.x + 16.4309f, Paths [3].transform.localPosition.y, Paths [3].transform.localPosition.z);
					ringMotion.propoControl = false;
				} else {
					Paths [asa].transform.localPosition = new Vector3 (Paths [3].transform.localPosition.x + 16.4309f, Paths [3].transform.localPosition.y, Paths [3].transform.localPosition.z);
					ringMotion.propoControl = false;
				}


			}
		}
		
	}
}
