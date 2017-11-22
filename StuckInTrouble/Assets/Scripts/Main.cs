using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public static string LuaPath;
	public static string PythonPath;

	private void Awake() {
		LuaPath = System.IO.Path.Combine(Application.streamingAssetsPath, "Lua");
		PythonPath = System.IO.Path.Combine(Application.streamingAssetsPath, "Python");
	}

	private void Start() {
		Debug.Log(string.Format("Unity Version: {0}", Application.unityVersion));
		Debug.Log(string.Format(".NET Version: {0}", Environment.Version));
	}
}
