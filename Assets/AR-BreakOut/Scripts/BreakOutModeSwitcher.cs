using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutModeSwitcher : MonoBehaviour {

	public GameObject SphereGenerate;
	public GameObject PlaneGenerate;

	private int appMode = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EnableBallCreation(bool enable)
	{
		SphereGenerate.SetActive (enable);
		PlaneGenerate.SetActive (!enable);
		
	}

	void OnGUI()
	{
		string modeString = appMode == 0 ? "Sphere" : "Generate";
		if (GUI.Button(new Rect(Screen.width -150.0f, 0.0f, 150.0f, 100.0f), modeString))
		{
			appMode = (appMode + 1) % 2;
			EnableBallCreation (appMode == 0);
		}

	}

}
