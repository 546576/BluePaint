using UnityEngine;

public class ColourScriptBlue : MonoBehaviour {
	private Color bluecube = Color.blue;

	void Start () 
	{
		gameObject.GetComponent<Renderer>().material.color = Color.blue;	 
	}
	
	//stores blue color; will change cursor colour to blue when clicked
	void OnMouseDown () 
	{
			GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = bluecube;
	}
}
