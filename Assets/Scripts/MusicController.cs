using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour 
{
	public GameObject SoundButton;

	public Sprite MusicOn;
	public Sprite MusicOff;

	// Update is called once per frame
	void Update () 
	{
		if (PlayerPrefs.GetInt ("Mute") == 1) 
		{
			AudioListener.pause = true;
		} 

		else 
		{
			AudioListener.pause = false;
		}

		if (PlayerPrefs.GetInt ("Mute") == 1) 
		{
			SoundButton.GetComponent<Image>().sprite = MusicOff;
		} 

		else 
		{
			SoundButton.GetComponent<Image>().sprite = MusicOn;
		}
	}

	public void Music_Button()
	{
		if(PlayerPrefs.GetInt ("Mute") == 1)
		{
			PlayerPrefs.SetInt ("Mute", 0);
		}

		else
		{
			PlayerPrefs.SetInt ("Mute", 1);
		}
	}
}
