using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour {
	private Text _debugText;
	private static readonly List<string> DebugString = new List<string>();
	public bool PrintDebug = true;

    
	private void Awake() {
		_debugText = GameObject.Find("Canvas").GetComponentInChildren<Text>();
	}

	private void Update () {
		if (PrintDebug) {
			_debugText.text = string.Join(System.Environment.NewLine, DebugString.ToArray());
		} else if (!PrintDebug) {
			_debugText.text = "";
		}
		
		DebugString.Clear();
	}

	public static void AppendDebug(string text) {
		DebugString.Add(text);
	}
}
