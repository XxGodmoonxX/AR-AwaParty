using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.iOS {
	public class NewSphereGenerater : MonoBehaviour {

		public GameObject ballPrefab;
		public GameObject soundObject;

		// public Camera cam;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

			//sound.csからデータを取得

			// soundObject.GetComponent<sound>().ReturnAccess();
			int noteNumber = soundObject.GetComponent<sound>().noteNumberNum;
			Debug.Log(noteNumber);

			//Sphere生成

			//CreatePrimitiveで動的にGameObjectであるCubeを生成する
      GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			//Cubeに適用するランダムな色を生成する
      Material material = new Material(Shader.Find("Diffuse")) {
      	// color = new Color(Random.value, Random.value, Random.value)
				color = new Color(noteNumber*3, noteNumber*3 - 29, noteNumber*3 - 29)
      };
			//ランダムに変化する色をCubeに適用する
      sphere.GetComponent<Renderer>().material = material;

			//sphereの大きさ指定
			float sphereSize = 1.0f;
      sphere.transform.localScale = new Vector3(sphereSize, sphereSize, sphereSize);

      //sphereにはRigidbodyを持たせて重力を与えておかないと、床の上には配置されないので注意が必要。Rigidbodyで重力を持たせないと宙に浮いた状態になる
			// Rigidbodyを取得
      sphere.AddComponent<Rigidbody>();

			// ボール発生位置をballprefab = sphereの位置に変更
			// けどなんか横に発射されちゃう
			// sphere.GetComponent<Rigidbody>().position = ballPrefab.transform.position;

			// ボール発生位置をballprefab = sphereの位置に変更
			// からのY方向に球を発射
			sphere.transform.position = ballPrefab.transform.TransformPoint(Random.Range(-0.2f, 0.2f), 0.1f, -0.1f);

			//力を加える？
			// sphere.GetComponent<Rigidbody>().AddForce(0, 0, 0);
			// sphere.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0,1f,2f),ForceMode.Impulse);
		}
	}
}