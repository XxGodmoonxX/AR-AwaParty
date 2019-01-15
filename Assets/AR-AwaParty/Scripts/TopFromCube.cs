using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFromCube : MonoBehaviour {

	public GameObject soundObject;
	public GameObject CubePrefab;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// soundObject.GetComponent<sound>().ReturnAccess();
		int noteNumber = soundObject.GetComponent<sound>().noteNumberNum;
		Debug.Log(noteNumber);

		if (noteNumber > 100) {
      GameObject Cube= GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Material material = new Material(Shader.Find("Diffuse")) {
      	// color = new Color(Random.value, Random.value, Random.value)
				color = new Color(Random.Range(noteNumber*3, 255), Random.Range(0, 10), Random.Range(0, 10))
      };
      Cube.GetComponent<Renderer>().material = material;
			float cubeSize = 0.3f;
      Cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
      Cube.AddComponent<Rigidbody>();
			Cube.transform.position = CubePrefab.transform.TransformPoint(0, -1f, 0);
			Cube.GetComponent<Rigidbody>().AddForce(CubePrefab.transform.TransformDirection(0, -3f, 1f),ForceMode.Impulse);

		}
	}
}
