using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour {
	public string Scene;
	[Range(0, 100)]
	public int Wait = 35;
	public GameObject Text;

	private int _count;

	private void Update() {
		var sum = _count / (double) Wait;
		Text.GetComponent<TextMesh>().text = sum * 100 + "%";
		Debug.Log(sum);
	}

	private void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count += 1;
		}
		
		if (other.gameObject.CompareTag("Player")) {
			if (_count == Wait) {
				SceneManager.LoadScene(Scene);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count = 0;
		}
	}

	private void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_count = 0;
		}
	}
}
