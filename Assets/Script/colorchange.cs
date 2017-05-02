using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour {

	public Color[] colorLerp;
	private Color colorStart;
	private Color colorEnd;

	public Camera back;
	private int sav = 0;
	private bool wait ;
	int i,a;
	float t;
	void Start () {
	//	back.backgroundColor= colorLerp [0];
		colorStart=colorLerp [0];
		colorEnd=colorLerp [0];
		sav = 0;
		a = 0;
		t = 0;
		wait = true;
	
	}
	public void colorchanger( Color start, Color end)
	{

		back.backgroundColor = Color.Lerp(start, end, t);
		if (t < 1) {
			t += Time.deltaTime;
		}
		sav++;
		if (sav >= 150) {

			wait = true;
			a++;
		}
	}


	void LateUpdate () {
		if (ringMotion.scoree % 5 == 0 && wait&& a>0&& ringMotion.track) {
			Debug.Log("com");
			t = 0;
			sav = 0;
			wait = false;
			i++;
			colorStart = colorLerp [i - 1];
			colorEnd = colorLerp [i];
			if (i >= 9) {
				i = 0;
			}

		
		}

		colorchanger (colorStart, colorEnd);
	}
}
