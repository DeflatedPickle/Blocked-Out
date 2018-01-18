using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	public string Scene;
	[Range(0, 100)]
	public int Wait = 35;
	public GameObject Text;

	private int _count;
	private AudioSource _exit;

	private void Awake() {
		_exit = GetComponent<AudioSource>();
	}

	private void Update() {
		var sum = _count / (double) Wait;
		Text.GetComponent<TextMesh>().text = sum * 100 + "%";
	}

	private void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count += 1;
		}
		
		if (other.gameObject.CompareTag("Player")) {
			if (_count == Wait) {
				_exit.Play();
				SceneManager.LoadScene(Scene);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count = 0;
			Text.SetActive(true);
		}
	}

	private void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count = 0;
			Text.SetActive(false);
		}
	}
}
