using UnityEngine;
using System.Collections;

public class PaintTool : MonoBehaviour {

    void Start() { }
    void Update() { }

    //Button script that sets cursor to 'paint' mode
    public void OnClick()
    {
        GameObject.Find("GOCursorColor").GetComponent<CursorColour>().shadetool = false;
        Debug.Log("shade activated");
    }
}
