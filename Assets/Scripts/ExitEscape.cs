using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitEscape : MonoBehaviour 
{
	

	string toastString;
	AndroidJavaObject currentActivity;

	int ButtonCounter;

	void Start()
	{
		ButtonCounter = 0;
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			ButtonCounter++;
			if (ButtonCounter == 1) 
			{
				StartCoroutine (msg());
			}

			StartCoroutine (Waiter());
		}
	}

	IEnumerator msg()
	{
		MyShowToastMethod ("Press Again To Quit...");
		yield return null;
	}
	IEnumerator Waiter()
	{
		yield return new WaitForSeconds (0.5f);

		if (ButtonCounter == 2) 
		{
//			Application.Quit ();
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		} 

		else 
		{
			ButtonCounter = 0;
		}
	}

	public void MyShowToastMethod (string msg)
	{
		if (Application.platform == RuntimePlatform.Android) 
		{
			showToastOnUiThread (msg);
		}
	}

	void showToastOnUiThread(string toastString)
	{
		AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

		currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		this.toastString = toastString;

		currentActivity.Call ("runOnUiThread", new AndroidJavaRunnable (showToast));
	}

	void showToast()
	{
		Debug.Log ("Running on UI thread");
		AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
		AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
		AndroidJavaObject javaString=new AndroidJavaObject("java.lang.String",toastString);
		AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject> ("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));
		toast.Call ("show");
	}
}
