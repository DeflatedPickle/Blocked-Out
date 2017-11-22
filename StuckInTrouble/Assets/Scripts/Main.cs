using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public static string LuaPath;

	private void Start () {
		Debug.Log(string.Format(".NET Version: {0}", Environment.Version));
		
		LuaPath = System.IO.Path.Combine(Application.streamingAssetsPath, "Lua");
	}
}
