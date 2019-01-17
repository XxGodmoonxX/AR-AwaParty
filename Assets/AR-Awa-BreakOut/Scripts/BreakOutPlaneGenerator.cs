using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutPlaneGenerator : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//タップしたら1回発動
		if( 0 < Input.touchCount){
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				//CreatePrimitiveで動的にGameObjectであるplaneを生成する
				GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);

				Material material = new Material(Shader.Find("Diffuse")) {
					// color = new Color(Random.value, Random.value, Random.value, alpha)
					color = new Color(255, 255, 255, 0)
				};
				plane.GetComponent<Renderer>().material = material;

				plane.transform.position = cam.transform.TransformPoint(0, 0, 0.5f);

				float sphereSize = 1.0f;
				plane.transform.localScale = new Vector3(sphereSize, sphereSize, sphereSize);

				plane.AddComponent<Rigidbody>();
				//Planeには重力かけない
				plane.AddComponent<Rigidbody>().useGravity = false;
			}
		}
	}
}
