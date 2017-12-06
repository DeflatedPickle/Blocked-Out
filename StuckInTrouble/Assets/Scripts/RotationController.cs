using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {
	private RotationManager _rotationManager;

	private void Awake() {
		_rotationManager = GetComponent<RotationManager>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			_rotationManager.RotateRight();
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			_rotationManager.RotateLeft();
		}
	}
}
