using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource aud = GetComponent<AudioSource>();
    // マイク名、ループするかどうか、AudioClipの秒数、サンプリングレート を指定する
    aud.clip = Microphone.Start(null, true, 10, 44100);
    aud.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
