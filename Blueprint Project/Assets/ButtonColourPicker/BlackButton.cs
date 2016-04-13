using UnityEngine;

public class BlackButton : MonoBehaviour {


    void start()
    { }

    
    // creates and sets a color, then applies the colour to the 'banked' CursorColorLeftClick variable
	public void OnClick () {
		
		
		Color blackcube = Color.black;
		GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = blackcube;
		
		
	}
	
	
}
