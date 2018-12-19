using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public GameObject score_object = null; //Text
	// public GameObject score_object_final = null; //Text


	private float  MaxTime = 60f; //秒

	// private float acx_x = 0;
	// private	float acx_y = 0;
	// private float acx_z = 0;
	private float acxNum = 0;

	// Use this for initialization
	void Start () {
		Text score_text = score_object.GetComponent<Text>();
		acxNum = 0;
		score_text.text = acxNum.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		var acx = Vector3.zero;
		acx.x += Mathf.Abs(Input.acceleration.x);
		acx.y += Mathf.Abs(Input.acceleration.y);
		acx.z += Mathf.Abs(Input.acceleration.z);

		acxNum = Mathf.Abs(acx.x + acx.y + acx.z);
		// acx += 0.00001f;
		Text score_text = score_object.GetComponent<Text>();
		score_text.text = acxNum.ToString();

		if(Time.time > 5000) {
			// acx = acx_x + acx_y + acx_z + 1.0f;
			//オブジェクトからTextコンポーネント取得
			// Text score_text = score_object.GetComponent<Text>();
			//テキスト入れ替える
			// score_text.text = acx.ToString();
		}


		if(Time.time == MaxTime*1000) {
			// acx = acx_x + acx_y + acx_z;
			//オブジェクトからTextコンポーネント取得
			// Text score_text = score_object.GetComponent<Text>();
			//テキスト入れ替える
			// score_text.text = acx.ToString();
		}
	}
}
