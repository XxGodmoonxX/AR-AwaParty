using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //これでText使える

public class scoreScript : MonoBehaviour {

	public Text scoreText; //Text用変数
  private int score = 0; //スコア計算用変数

	// Use this for initialization
	void Start () {
		score   = 0;
    SetScore();   //初期スコアを代入して表示
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//cube同士での衝突＋100 cube以外との衝突＋100
    void OnCollisionEnter( Collision collision )
    {
        string yourTag  = collision.gameObject.tag;

        if( yourTag == "Cube" )
        {
            score += 1;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format( "Score:{0}", score );
    }
}
