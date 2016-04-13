using UnityEngine;

public class GreenButton : MonoBehaviour {
	
	// creates and sets a color, then applies the colour to the 'banked' CursorColorLeftClick variable
	public void OnClick () {
		
		
		Color greencube = Color.green;
		GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = greencube;
		
		
	}
	
	
}
