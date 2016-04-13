using UnityEngine;

public class RedButton : MonoBehaviour {


	// creates and sets a color, then applies the colour to the 'banked' CursorColorLeftClick variable
	public void OnClick() {
        Debug.Log("red colour selected");
			Color redcube = new Color(1,0,0,1);
			GameObject.Find ("GOCursorColor").GetComponent<CursorColour> ().cursorcolorleftclick = redcube;

	}
	
}
