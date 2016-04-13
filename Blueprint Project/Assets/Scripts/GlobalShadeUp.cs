using UnityEngine;
using System.Collections;

public class GlobalShadeUp : MonoBehaviour {
    public bool gshadeupon = false;

    void Start() { }
    void Update() { }

    //Function that flags canvas to alter current colour shades towards being lighter
    public void OnMouse()
    {
        gshadeupon = true;
        Debug.Log("global shade up trigger working");
    }
}

