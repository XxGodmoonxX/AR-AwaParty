using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.iOS {
	public class SphereGenerater : MonoBehaviour {

		public GameObject ballPrefab;

		public Camera cam;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
			//CreatePrimitiveで動的にGameObjectであるCubeを生成する
      GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			//Cubeに適用するランダムな色を生成する
      Material material = new Material(Shader.Find("Diffuse")) {
      	// color = new Color(Random.value, Random.value, Random.value)
				color = new Color(Random.value, Random.value, Random.value)
      };
			//ランダムに変化する色をCubeに適用する
      sphere.GetComponent<Renderer>().material = material;

			//sphereの大きさ指定
			float sphereSize = 0.5f;
      sphere.transform.localScale = new Vector3(sphereSize, sphereSize, sphereSize);

      //sphereにはRigidbodyを持たせて重力を与えておかないと、床の上には配置されないので注意が必要。Rigidbodyで重力を持たせないと宙に浮いた状態になる

			// Rigidbodyを取得
      sphere.AddComponent<Rigidbody>();

			// ボール発生位置をballprefab = sphereの位置に変更
			// けどなんか横に発射されちゃう
			// sphere.GetComponent<Rigidbody>().position = ballPrefab.transform.position;

			// ボール発生位置をballprefab = sphereの位置に変更
			// からのY方向に球を発射
			sphere.transform.position = ballPrefab.transform.TransformPoint(0, 0.5f, -0.2f);
			// sphere.transform.position = ballPrefab.transform.TransformDirection(0, 0.5f, 0);


			//力を加える
			// sphere.GetComponent<Rigidbody>().AddForce(0, 0, 100f);
			// sphere.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0,1f,2f),ForceMode.Impulse);
		}
	}
}