using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using UnityEngine;

public class LuaInterpreter : MonoBehaviour {
	private Script _luaScript;

	private void Start () {
		_luaScript = new Script();
		Script.DefaultOptions.ScriptLoader = new EmbeddedResourcesScriptLoader();

		var filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "Lua");
		filePath = System.IO.Path.Combine(filePath, "TestLua.lua");
		
		var luaCode = System.IO.File.ReadAllText(filePath);
		Debug.Log(_luaScript.DoString(luaCode).String);
	}
}
