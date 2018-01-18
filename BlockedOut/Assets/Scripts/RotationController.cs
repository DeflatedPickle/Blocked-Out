using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {
	// private RotationManager _rotationManager;
	private AudioSource _audioSource;
	
	private float _desiredRot;
	[Range(1, 8)]
	public float Damping = 3;

	private void Awake() {
		// _rotationManager = GetComponent<RotationManager>();
		_audioSource = GetComponent<AudioSource>();
	}
 
	private void OnEnable() {
		_desiredRot = transform.eulerAngles.z;
	}

	private void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			// _rotationManager.RotateRight();
			_desiredRot -= 90;
			_audioSource.Play();
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			// _rotationManager.RotateLeft();
			_desiredRot += 90;
			_audioSource.Play();
		}
 
		var desiredRotQ = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, _desiredRot);
		transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotQ, Time.deltaTime * Damping);
	}
}
