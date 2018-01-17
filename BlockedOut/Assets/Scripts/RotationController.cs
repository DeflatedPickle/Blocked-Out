using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {
	private RotationManager _rotationManager;
	private AudioSource _audioSource;

	private void Awake() {
		_rotationManager = GetComponent<RotationManager>();
		_audioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			_rotationManager.RotateRight();
			_audioSource.Play();
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			_rotationManager.RotateLeft();
			_audioSource.Play();
		}
	}
}
