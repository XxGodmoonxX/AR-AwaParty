using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutSphereGenerator : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//タップしたら1回発動
		if( 0 < Input.touchCount){
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				//CreatePrimitiveで動的にGameObjectであるsphereを生成する
				GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				//sphereに適用するランダムな色を生成する
				Material material = new Material(Shader.Find("Diffuse"))
				{
					// color = new Color(Random.value, Random.value, Random.value)
					color = new Color(0, 0, 200)
				};
				//ランダムに変化する色をsphereに適用する
				sphere.GetComponent<Renderer>().material = material;
				//端末をタップして、ランダムな色のsphereを認識した平面上に投げ出すように追加していく
				//sphereの大きさも0.2fとして指定している
				sphere.transform.position = cam.transform.TransformPoint(0, 0, 0.5f);
				// sphere.transform.position = cam.transform.TransformPoint(0.5f, 0, 0);
				float sphereSize = 1.0f;
				sphere.transform.localScale = new Vector3(sphereSize, sphereSize, sphereSize);
				//sphereにはRigidbodyを持たせて重力を与えておかないと、床の上には配置されないので注意が必要。Rigidbodyで重力を持たせないとsphereは宙に浮いた状態になる
				sphere.AddComponent<Rigidbody>();
				//これでタップしたときに斜め上にキューブ飛んでいく？そして衝突計算
				//これ斜めかな
				// sphere.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0,1f,2f),ForceMode.Impulse);
				//これ横？
				sphere.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0, 2f, 0),ForceMode.Impulse);
			}
		}
	}
}
