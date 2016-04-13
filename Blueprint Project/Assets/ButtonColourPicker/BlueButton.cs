using UnityEngine;

public class BlueButton : MonoBehaviour {

	// creates and sets a color, then applies the colour to the 'banked' CursorColorLeftClick variable
	public void OnClick () {


		Color bluecube = Color.blue;
		GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = bluecube;


	}
	

}
