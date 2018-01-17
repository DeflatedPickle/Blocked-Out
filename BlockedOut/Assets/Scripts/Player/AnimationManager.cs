using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {
	public void Squash(float x, float y, float z = 0) {
		transform.localScale -= new Vector3(x, y, z);
	}

	public void Stretch(float x, float y, float z = 0) {
		transform.localScale += new Vector3(x, y, z);
	}

	public void Set(float x, float y, float z = 0) {
		transform.localScale = new Vector3(x, y, z);
	}
}
