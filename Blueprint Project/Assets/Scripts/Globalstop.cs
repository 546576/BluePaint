using UnityEngine;
using System.Collections;

public class Globalstop : MonoBehaviour {

    void Start() { }
    void Update() { }
   //Controller script that halts any current global shading processes 
    public void OnClick2()
    {
        GameObject.Find("Global Shader Object").GetComponent<GlobalShade>().gshadedownon = false;
        GameObject.Find("GlobalShadeUp").GetComponent<GlobalShadeUp>().gshadeupon = false;
        Debug.Log("global stop successful");
    }
}
