using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {
	// private RotationManager _rotationManager;
	private AudioSource _audioSource;
	
	public float DesiredRot;
	[Range(1, 8)]
	public float Damping = 3;

	private void Awake() {
		// _rotationManager = GetComponent<RotationManager>();
		_audioSource = GetComponent<AudioSource>();
	}
 
	private void OnEnable() {
		DesiredRot = transform.eulerAngles.z;
	}

	private void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			// _rotationManager.RotateRight();
			DesiredRot -= 90;
			_audioSource.Play();
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			// _rotationManager.RotateLeft();
			DesiredRot += 90;
			_audioSource.Play();
		}
 
		var desiredRotQ = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, DesiredRot);
		transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotQ, Time.deltaTime * Damping);
	}
}
