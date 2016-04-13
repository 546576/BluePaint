using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class currentcolourscript : MonoBehaviour {
    private Color currentcolor; 
	
	void Start () {
	
	}

    //UI object that displays the current cursor's stored value
    void Update () {
       currentcolor  = GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick;
       GetComponent<Image>().color = currentcolor;

    }
}
