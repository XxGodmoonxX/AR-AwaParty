using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {

	Animation anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		anim.Play ();

		// transform.Rotate(-180, 90, -180);
	}
	
	// Update is called once per frame
	void Update () {
		// if (!anim.isPlaying) {
			transform.Rotate(0, 3, 0);
		// }
	}
}
