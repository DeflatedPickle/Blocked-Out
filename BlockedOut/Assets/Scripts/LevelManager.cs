using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public List<GameObject> LevelList;
	// public List<System.Tuples.Tuple<float, float>> LevelSpawnList;
	// public List<float> SpawnXList;
	// public List<float> SpawnYList;
	private int _index = -1;

	private GameObject _player;
	private GameObject _spawnGameObject;

	private void Awake() {
		_player = GameObject.Find("Player");
	}

	private void Start() {
		NextLevel();
	}

	public void NextLevel() {
		if (_index < LevelList.Count - 1 || _index == -1) {
			GameObject.Find("LevelStack").GetComponent<RotationController>().DesiredRot = 0f;
			
			/*var rotation = GameObject.Find("LevelStack").transform.rotation;
			rotation.z = 0f;
			GameObject.Find("LevelStack").transform.rotation = rotation;*/

			try {
				LevelList[_index].SetActive(false);
			}
			catch (ArgumentOutOfRangeException) { }

			_index += 1;

			LevelList[_index].SetActive(true);
			
			_spawnGameObject =  GameObject.Find("LevelStack").transform.Find("Level" + (_index + 1)).gameObject.transform.Find("Spawn").gameObject; // GameObject.Find("Level" + _index + "/Spawn");
			// _player.transform.position = new Vector2(float.Parse(LevelSpawnList[_index].First().ToString()), float.Parse(LevelSpawnList[_index].Last().ToString()));
			// _player.transform.position = new Vector2(SpawnXList[_index], SpawnYList[_index]);
			_player.transform.position = _spawnGameObject.transform.position;
		}
		else {
			SceneManager.LoadScene("Thanks");
		}
	}
}
