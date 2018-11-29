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
		
	}
}
