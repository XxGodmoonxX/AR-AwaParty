using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundExample : MonoBehaviour {

	public AudioSpectrum spectrum;
  public Transform[] cubes;
  public float scale;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < cubes.Length; i++) {
    	var cube = cubes[i];
      var localScale = cube.localScale;
      localScale.y = spectrum.Levels[i] * scale;
      cube.localScale = localScale;
    }
	}
}
