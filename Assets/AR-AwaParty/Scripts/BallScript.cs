using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	//PublicでGameobject型の変数
	public GameObject ball_blue;
	public GameObject ball_red;

	//float型の変数pos
	private float pos_blue;
	private float pos_red;

	// Use this for initialization
	void Start () {
		//posにballのy座標を格納 ボールは上下にバウンド、yの値を取得しておく必要がある
		pos_blue = ball_blue.transform.position.y;
		pos_red = ball_red.transform.position.y;

		//ballに与えられているRigidbodyのuseGravityをFalse
		//これでボールには重力が働かず宙に浮いた状態に
		ball_blue.GetComponent<Rigidbody>().useGravity = false;
		ball_red.GetComponent<Rigidbody>().useGravity = false;
	}

	// Update is called once per frame
	void Update () {
		// isSleepingでボールが停止してるか判断、ボールが停止していればRigidbodyのUsegravityにTrueを指定して重力働かせる これでボールは下に落下、そして透明なPlaneに衝突しバウンド
		if (ball_blue.GetComponent<Rigidbody>().IsSleeping() &&
		 		ball_red.GetComponent<Rigidbody>().IsSleeping()
		) {
				ball_blue.GetComponent<Rigidbody>().useGravity = true;
				ball_red.GetComponent<Rigidbody>().useGravity = true;
				// ボールをバウンド
				ball_blue.transform.position = new Vector3(ball_blue.transform.position.x, pos_blue, ball_blue.transform.position.z);
				ball_red.transform.position = new Vector3(ball_red.transform.position.x, pos_red, ball_red.transform.position.z);
		}
	}
}
