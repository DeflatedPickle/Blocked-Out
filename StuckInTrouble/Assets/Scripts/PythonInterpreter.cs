using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using UnityEngine;

public class PythonInterpreter {
    private static readonly ScriptEngine PythonScript;
    private static readonly ScriptScope PythonScope;
    private static MemoryStream _memoryStream;

    static PythonInterpreter() {
        PythonScript = Python.CreateEngine();
        PythonScope = PythonScript.CreateScope();
    }

    public object Run(string pythonCode) {
        _memoryStream = new MemoryStream();
        PythonScript.Runtime.IO.SetOutput(_memoryStream, new StreamWriter(_memoryStream));

        var result = PythonScript.Execute(pythonCode, PythonScope);

        Debug.Log(ReadFromStream(_memoryStream));
        _memoryStream.Close();

        return result;
    }

    public void Log(string pythonCode) {
        var result = Run(pythonCode);

        Debug.Log(result.ToString());
    }

    /* Credit: seshapv
     * Link: https://blogs.msdn.microsoft.com/seshadripv/2008/07/08/how-to-redirect-output-from-python-using-the-dlr-hosting-api/
     */
    private static string ReadFromStream(MemoryStream stream) {
        var length = (int) stream.Length;
        var bytes = new byte[length];

        stream.Seek(0, SeekOrigin.Begin);
        stream.Read(bytes, 0, (int) stream.Length);

        return Encoding.GetEncoding("utf-8").GetString(bytes, 0, (int) stream.Length - 1);
    }
}