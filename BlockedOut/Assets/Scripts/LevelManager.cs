using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public List<GameObject> LevelList;
	// public List<System.Tuples.Tuple<float, float>> LevelSpawnList;
	public List<float> SpawnXList;
	public List<float> SpawnYList;
	private int _index;

	private GameObject _player;

	private void Awake() {
		_player = GameObject.Find("Player");
	}

	public void NextLevel() {
		LevelList[_index].SetActive(false);

		_index += 1;
		
		LevelList[_index].SetActive(true);
		// _player.transform.position = new Vector2(float.Parse(LevelSpawnList[_index].First().ToString()), float.Parse(LevelSpawnList[_index].Last().ToString()));
		_player.transform.position = new Vector2(SpawnXList[_index], SpawnYList[_index]);
	}
}
