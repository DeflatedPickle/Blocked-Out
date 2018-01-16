using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[InitializeOnLoad]
public class Main : MonoBehaviour {
    static Main() {
        Debug.Log(string.Format("Unity Version: {0}", Application.unityVersion));
        Debug.Log(string.Format(".NET Version: {0}", Environment.Version));
    }
}