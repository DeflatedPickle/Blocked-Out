using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using UnityEngine;

public class PythonInterpreter : MonoBehaviour {
	private ScriptEngine _pythonScript;
	private ScriptScope _pythonScope;
	private MemoryStream _memoryStream;

	private void Start () {
		_pythonScript = Python.CreateEngine();
		_pythonScope = _pythonScript.CreateScope();
		
		var pythonCode = System.IO.File.ReadAllText(System.IO.Path.Combine(Main.PythonPath, "TestPython.py"));
		Run(pythonCode);
	}

	public object Run(string pythonCode) {
		_memoryStream = new MemoryStream();
		_pythonScript.Runtime.IO.SetOutput(_memoryStream, new StreamWriter(_memoryStream));
		
		var result = _pythonScript.Execute(pythonCode, _pythonScope);
		
		Debug.Log(ReadFromStream(_memoryStream));
		_memoryStream.Close();
		
		return result;
	}

	public void Log(string pythonCode) {
		var result = Run(pythonCode);
		
		Debug.Log(result.ToString());
	}
	
	private static string ReadFromStream(MemoryStream stream) {
		var length = (int)stream.Length;
		var bytes = new byte[length];
 
		stream.Seek(0, SeekOrigin.Begin);
		stream.Read(bytes, 0, (int)stream.Length);
 
		return Encoding.GetEncoding("utf-8").GetString(bytes, 0, (int)stream.Length-1);
	}
}
