using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using UnityEngine;

public class LuaInterpreter : MonoBehaviour {
	private Script _luaScript;

	private void Start () {
		Script.DefaultOptions.ScriptLoader = new EmbeddedResourcesScriptLoader();
		Script.DefaultOptions.DebugPrint = Debug.Log;
		
		_luaScript = new Script();

		//var filePath = System.IO.Path.Combine(Main.LuaPath, "TestLua.lua");
		
		//var luaCode = System.IO.File.ReadAllText(filePath);
		var luaCode = "print(string.format('Lua Version: %s', _VERSION))";
		Run(luaCode);
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
