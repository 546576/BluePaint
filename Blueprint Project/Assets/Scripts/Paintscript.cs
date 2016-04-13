using UnityEngine;
public class Paintscript : MonoBehaviour {




    public bool load = false;
    public Texture2D importedimage;
	public int Widthofimage = 10;//total width of image
    public int Heightofimage = 10;//total height of image
    private int hc = 0; //current pixel height location
	private int wc = 0; //current pixel width location
	private Vector3 pixposition;
    public bool globalswitch = false;//triggers global shades


    //basic loop that creates a canvas of paintable tiles based on width/height variables
    void Start () {

        //bool that detects if the loaded image is to be used as the canvas
        if (load == true)
        {
            for (int i = 0; i < Heightofimage; i++)//for loop that cycles through the current line then moves to the next line of pixels
            {
                for (int j = 0; j < Widthofimage; j++)//for loop to cycle through all pixels in a line
                {
                    Color canvascolour = importedimage.GetPixel(wc, hc);//loads colour of the selected pixel
                    GameObject PixelCube = (GameObject)Instantiate(Resources.Load("PixelCube")); //instantiates canvas pixel
                    PixelCube.GetComponent<Renderer>().material.color = canvascolour;//changes colour of canvas to match pixel
                    PixelCube.transform.localScale = new Vector3(1, 1, .01f);//changes scale of canvas
                    PixelCube.transform.position = new Vector3(wc, hc, 0);//moves canvas into space based on current pixel's coordinates in the loaded image
                    wc++;//moves to next pixel in line
                }
                wc = 0;//resets X position in line
                hc++;//moves down a line
            }


        }

        if (load == false)//function that creates a blank canvas if there is no image loaded/'Load' bool is false
        {

            for (int i = 0; i < Heightofimage; i++)//creates a for loop that arranges pixels in a grid
            {
                for (int j = 0; j < Widthofimage; j++)
                {

                    GameObject PixelCube = (GameObject)Instantiate(Resources.Load("PixelCube"));

                    PixelCube.transform.localScale = new Vector3(1, 1, .01f);
                    PixelCube.transform.position = new Vector3(hc, wc, 0);


                    wc++;
                }
                wc = 0;
                hc++;
            }
        }


		
	}

   //update function for basic camera control
    public void Update()
    {
        if (Input.GetKey(KeyCode.D))//pans camera
        {
            gameObject.transform.position += new Vector3(1f, 0, 0);
            Debug.Log("right work");
        }

        if (Input.GetKey(KeyCode.A))//pans camera
        {
            gameObject.transform.position -= new Vector3(1f , 0, 0);
            Debug.Log("left work");
        }

        if (Input.GetKey(KeyCode.W))//pans camera
        {
            gameObject.transform.position += new Vector3(0f, 1f, 0);
            Debug.Log("upwork");
        }

        if (Input.GetKey(KeyCode.S))//pans camera
        {
            gameObject.transform.position -= new Vector3(0f, 1f, 0);
            Debug.Log("downwork");
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0) //scroll wheel back
        {
            gameObject.transform.position -= new Vector3(0, 0, 3f);
            Debug.Log("scrollbackwork");           
        }


        if (Input.GetAxis("Mouse ScrollWheel") > 0) //scroll wheel forward
        {
            gameObject.transform.position += new Vector3(0, 0, 3f);
            Debug.Log("scrollforwardwork");
        }

    }
}
