using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using UnityEngine;

public class LuaInterpreter : MonoBehaviour {
	private Script _luaScript;

	// Use this for initialization
	private void Start () {
		_luaScript = new Script();
		Script.DefaultOptions.ScriptLoader = new EmbeddedResourcesScriptLoader();

		Load("return 123");
	}
	
	// Update is called once per frame
	private void Update () {
		
	}

	public void Load(string luaCode) {
		DynValue result = _luaScript.DoString(luaCode);
		Debug.Log(result.Number);
	}
}
