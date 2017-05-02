using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ringMotion : MonoBehaviour
{

	public static int pathIdentifier;
	public static bool propoControl;
	public static bool track;
	public static bool track1;
	public static int scoree;
	public int highScore;
	public Text scoretext;
	public Text hightext;
	public GameObject high;
	public GameObject score;
	public GameObject restart;
	public Text bestScore;
	public GameObject menueCanvas;

	public GameObject DisableObject;
	 
	public AudioClip Click;


	void Start () 
	{
		track1 = false;
		scoree = 0;
		propoControl = false;
		track = true;
		highScore = PlayerPrefs.GetInt ("Circule"); 
		bestScore.text = highScore.ToString ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0) && track && EventSystem.current.currentSelectedGameObject != DisableObject)
		{
			GetComponent<AudioSource>().PlayOneShot(Click);

			menueCanvas.SetActive(false);
			score.SetActive(true);
			track1=true;
			gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 4f, 0f);
			scoree++;
			scoretext.text = scoree.ToString ();
		}
	}

	public void Homee()
	{
		SceneManager.LoadScene("circule");
	}

	public void Restart()
	{
		SceneManager.LoadScene("circule");
	}

	void OnTriggerEnter (Collider col)
	{
		Debug.Log("1237");

		if (col.gameObject.tag == "path1") 
		{
			pathIdentifier = 0;
			propoControl = true;
			Debug.Log ("0");
		}
		if (col.gameObject.tag == "path2") 
		{
			pathIdentifier = 1;
			propoControl = true;
			Debug.Log ("1");
		}
		if (col.gameObject.tag == "path3") 
		{
			pathIdentifier = 2;
			propoControl = true;
			Debug.Log ("2");
		}
		if (col.gameObject.tag == "path4") 
		{
			pathIdentifier = 3;
			propoControl = true;
			Debug.Log ("3");
		} 

		if (col.gameObject.tag == "track")
		{
			track = false;
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			//Button_Manager.Activate = true;

			restart.SetActive (true);

			if (highScore < scoree)
			{
				score.SetActive (false);
				highScore = scoree;
				hightext.text = (" New High Score  " +highScore);
				high.SetActive(true);

				PlayerPrefs.SetInt ("Circule", scoree);
			}
		}
	}
}
