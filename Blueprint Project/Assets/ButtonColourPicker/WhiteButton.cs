using UnityEngine;

public class WhiteButton : MonoBehaviour {
	
	// creates and sets a color, then applies the colour to the 'banked' CursorColorLeftClick variable
	public void OnClick () {
		
		
		Color whitecube = Color.white;
		GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = whitecube;
		
		
	}
	
	
}
