using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 空の Audio Sourceを取得
		AudioSource audio = GetComponent<AudioSource>();
		// Audio Source の Audio Clip をマイク入力に設定
    // マイク名nullならデフォルト、ループするかどうか、AudioClipの秒数、サンプリングレート を指定する
    audio.clip = Microphone.Start(null, true, 10, 44100);
		// マイクが Ready になるまで待機（一瞬）
		while (Microphone.GetPosition(null) <= 0) {}
		// 再生開始（録った先から再生、スピーカーから出力するとハウリングします）
    audio.Play();
	}

	// Update is called once per frame
	void Update () {
		// float[] spectrum = new float[1024];
    // AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
		// Debug.Log(spectrum[1]);

		// //ピッチの取得
		// var maxIndex = 0;
		// var maxValue = 0.0f;
		// for (int i = 0; i <= spectrum.Length; i++) {
		// 	var val = spectrum[i];
		// 	if (val > maxValue) {
		// 		// maxValue が最も大きい周波数成分の値で
		// 		maxValue = val;
		// 		// maxIndex がそのインデックス。欲しいのはこっち。
		// 		maxIndex = i;
		// 	}
		// }

		// var freq = maxIndex * AudioSettings.outputSampleRate / 2 / spectrum.Length;
	}
}
