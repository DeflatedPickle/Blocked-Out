using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public static string LuaPath;

	private void Start () {
		LuaPath = System.IO.Path.Combine(Application.streamingAssetsPath, "Lua");
	}
}
