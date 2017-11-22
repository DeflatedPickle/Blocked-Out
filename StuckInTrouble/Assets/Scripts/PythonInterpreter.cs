using System.Collections;
using System.Collections.Generic;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using UnityEngine;

public class PythonInterpreter : MonoBehaviour {
	private ScriptEngine _pythonScript;

	private void Start () {
		_pythonScript = Python.CreateEngine();

		var pythonCode = "import sys;print sys.version";
		Run(pythonCode);
	}

	public object Run(string pythonCode) {
		return _pythonScript.Execute(pythonCode);
	}
}
