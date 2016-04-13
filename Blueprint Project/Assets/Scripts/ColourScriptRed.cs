using UnityEngine;
public class ColourScriptRed : MonoBehaviour {
	public Color redcube = Color.red;

	void Start () 
	{
		gameObject.GetComponent<Renderer>().material.color = Color.red;	 
	}
	
	//stores red colour; will apply red to cursorcolour variable when clicked 
	void OnMouseDown () 
	{
			GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = redcube;
	}
}
