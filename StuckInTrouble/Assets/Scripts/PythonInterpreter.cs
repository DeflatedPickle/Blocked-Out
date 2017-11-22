using System.Collections;
using System.Collections.Generic;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using UnityEngine;

public class PythonInterpreter : MonoBehaviour {
	private ScriptEngine _pythonScript;
	private ScriptScope _pythonScope;

	private void Start () {
		_pythonScript = Python.CreateEngine();
		_pythonScope = _pythonScript.CreateScope();

		var pythonCode = "import sys;print 'Python Version: %s' % sys.version";
		Run(pythonCode);
	}

	public object Run(string pythonCode) {
		return _pythonScript.Execute(pythonCode, _pythonScope);
	}

	public void Log(string pythonCode) {
		var result = Run(pythonCode);
		
		Debug.Log(result.ToString());
	}
}
