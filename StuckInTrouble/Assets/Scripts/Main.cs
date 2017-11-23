using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class Main : MonoBehaviour {
	internal static readonly string LuaPath;
	internal static readonly string PythonPath;

	public static readonly LuaInterpreter Lua;
	public static readonly PythonInterpreter Python;

	static Main() {
		LuaPath = System.IO.Path.Combine(Application.streamingAssetsPath, "Lua");
		PythonPath = System.IO.Path.Combine(Application.streamingAssetsPath, "Python");
		
		Debug.Log(string.Format("Unity Version: {0}", Application.unityVersion));
		Debug.Log(string.Format(".NET Version: {0}", Environment.Version));
		
		Lua = new LuaInterpreter();
		var luaCode = System.IO.File.ReadAllText(System.IO.Path.Combine(LuaPath, "TestLua.lua"));
		Lua.Run(luaCode);
		
		Python = new PythonInterpreter();
		var pythonCode = System.IO.File.ReadAllText(System.IO.Path.Combine(PythonPath, "TestPython.py"));
		Python.Run(pythonCode);
	}
}
