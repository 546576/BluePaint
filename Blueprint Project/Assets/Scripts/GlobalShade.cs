using UnityEngine;
using System.Collections;

public class GlobalShade : MonoBehaviour {


    void Start() { }
    void Update() { }


  //function that controls the pixel's global darker shade button
    public bool gshadedownon = false;
	public void OnMouseClick() {
              
            gshadedownon = true;
            Debug.Log("global shade down trigger working");     
    
    }
}
