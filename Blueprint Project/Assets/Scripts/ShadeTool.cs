using UnityEngine;
using System.Collections;

public class ShadeTool : MonoBehaviour {

    void Start() { }
    void Update() { }

    public void OnClick()
    {
       
            GameObject.Find("GOCursorColor").GetComponent<CursorColour>().shadetool = true;
            Debug.Log("shade activated");
                 
        
    }
}
