using UnityEngine;

public class PaintPixelScript : MonoBehaviour {

	private Color  currentcolor;
    private Color shade;
    private Color shademax;
    private Color shademin;
    private bool gshadedown;
    private bool gshadeup;
    private Color globalshade;
    private Color globalshadeup;
    private Color globalshadedown;
    

    private bool shaderbool = false;
	void Start () 
	{
			
	}
	// Update is called once per frame
	void Update ()
	{
      shaderbool = GameObject.Find("GOCursorColor").GetComponent<CursorColour>().shadetool;//constantly checks the bool for swapping between shader and paint tools 

        //whilst the next 2 lines work, they are so resource intensive it's impossible to use them beyond a 10x10 pixel image  

        if (GameObject.Find("Main Camera").GetComponent<Paintscript>().globalswitch == true)
        {
            gshadedown = GameObject.Find("Global Shader Object").GetComponent<GlobalShade>().gshadedownon; //constantly checks global shade down bool
            gshadeup = GameObject.Find("GlobalShadeUp").GetComponent<GlobalShadeUp>().gshadeupon;//constantly checks global shade up bool
        }

      if (gshadedown == true)//if gshade button is pressed, will change the colour of all canvas pixels down a shade until turned off
      { //stores the current colour, creates a new colour a shade darker, and lerps between the two
            globalshade = gameObject.GetComponent<Renderer>().material.color;
            globalshadedown = globalshade;
            globalshadedown -= new Color(0.01f, 0.01f, 0.01f, 0);
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(globalshade, globalshadedown, 1);
            Debug.Log("global shade down is working");
        }

        if (gshadeup == true)
        {//stores current colour, creats a colour a shade lighter, and lerps between the two
            globalshade = gameObject.GetComponent<Renderer>().material.color;
            globalshadeup = globalshade;
            globalshadeup += new Color(0.01f, 0.01f, 0.01f, 0);
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(globalshade, globalshadeup, 1);
            Debug.Log("global shade up is working");
        }
	}

	void OnMouseOver()
	{
        if (shaderbool == false)//bool for swapping between shade editing and colour editing
        {
            if (Input.GetMouseButton(0))//function that changes the canvas pixel to whatever colour is currently stored as the left click value
            {
                currentcolor = GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick;
                gameObject.GetComponent<Renderer>().material.color = currentcolor;
                Debug.Log("click paint is working");
            }

            if (Input.GetMouseButton(1))//function that applies whatever colour is on the canvas to the left click colour variable
            {

                currentcolor = gameObject.GetComponent<Renderer>().material.color;
                GameObject.Find("GOCursorColor").GetComponent<CursorColour>().cursorcolorleftclick = currentcolor;
                Debug.Log("colour dropper is working");
            }
        }

        if (shaderbool == true)//individual pixel shader; same effect as global pixel shader but localized to the pixel you click on
        {
            if (Input.GetMouseButton(0))//left click shades down
            {
                shade = gameObject.GetComponent<Renderer>().material.color;
                shademax = shade;
                shademax -= new Color (0.01f, 0.01f, 0.01f, 0);
                gameObject.GetComponent<Renderer>().material.color = Color.Lerp(shade, shademax, 1);
                Debug.Log("paint shade down is working");
            }

            if (Input.GetMouseButton(1))//right click shades up 
            {

                shade = gameObject.GetComponent<Renderer>().material.color;
                shademin = shade;
                shademin += new Color(0.01f, 0.01f, 0.01f, 0);
                gameObject.GetComponent<Renderer>().material.color = Color.Lerp(shade, shademin, 1);
                Debug.Log("paint shade up is working");
            }
        }
    }
}