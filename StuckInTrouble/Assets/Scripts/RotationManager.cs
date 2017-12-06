using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour {	
	public void RotateRight() {
		transform.Rotate(0f, 0f, 90f);
	}

	public void RotateLeft() {
		transform.Rotate(0f, 0f, -90f);
	}
}
