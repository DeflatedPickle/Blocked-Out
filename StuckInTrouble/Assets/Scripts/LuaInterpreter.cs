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

		var filePath = System.IO.Path.Combine(Main.LuaPath, "TestLua.lua");
		
		var luaCode = System.IO.File.ReadAllText(filePath);
		Log(luaCode);
	}

	public DynValue Run(string luaCode) {
		return _luaScript.DoString(luaCode);
	}

	public void Log(string luaCode) {
		var result = Run(luaCode);

		switch (result.Type) {
			case DataType.String:
				Debug.Log(result.String);
				break;
				
			case DataType.Number:
				Debug.Log(result.Number);
				break;
				
			case DataType.Boolean:
				Debug.Log(result.Boolean);
				break;
		}
	}
}
