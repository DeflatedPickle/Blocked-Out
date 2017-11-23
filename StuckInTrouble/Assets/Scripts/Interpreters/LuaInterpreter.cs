using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using UnityEngine;

public class LuaInterpreter {
    private static readonly Script LuaScript;

    static LuaInterpreter() {
        Script.DefaultOptions.ScriptLoader = new EmbeddedResourcesScriptLoader();
        Script.DefaultOptions.DebugPrint = Debug.Log;

        LuaScript = new Script();
    }

    public DynValue Run(string luaCode) {
        return LuaScript.DoString(luaCode);
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