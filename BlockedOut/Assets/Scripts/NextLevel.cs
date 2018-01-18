using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	// public string Scene;
	[Range(0, 100)]
	public int Wait = 35;
	public GameObject Text;

	private int _count;
	private TextMesh _text;
	private AudioSource _exit;
	private AudioSource _countSound;
	private LevelManager _levelManager;

	private void Awake() {
		_text = Text.GetComponent<TextMesh>();
		_exit = GetComponents<AudioSource>()[0];
		_countSound = GetComponents<AudioSource>()[1];
		_levelManager = GameObject.Find("Manager").GetComponent<LevelManager>();
	}

	private void Update() {
		var sum = _count / (double) Wait;
		_text.text = sum * 100 + "%";
	}

	private void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count += 1;
			_countSound.Play();
		}
		
		if (other.gameObject.CompareTag("Player")) {
			if (_count == Wait) {
				_exit.Play();
				// SceneManager.LoadScene(Scene);
				_levelManager.NextLevel();
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
