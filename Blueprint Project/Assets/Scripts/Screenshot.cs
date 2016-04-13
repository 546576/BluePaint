using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {
    //screenshots

    GameObject Canvastrig;
    private int screenshotcount = 1;

    void start()
    {
    }
    public void OnClickDown()//starts the coroutine required to save the image
    {
        StartCoroutine(CaptureScreen());
    }

    public IEnumerator CaptureScreen()//function to save the currently viewed image
    {
        Canvastrig = GameObject.Find("CanvasHolder");//finds the game object containing the canvas

        yield return null; //wait a frame before turning off the UI
        foreach (Transform t in Canvastrig.transform) //for loop that disables the canvas (and anything else marked as canvas) within the canvas holder game object
        {
            if (t.tag == "Canvas")
            {
                t.gameObject.SetActive(false);
                Debug.Log("turn off working");
            }

        }

        yield return new WaitForEndOfFrame();//waits until end of current frame
        
        Application.CaptureScreenshot("Assets/Resources/SavedImage" + screenshotcount + ".png", 1); //captures the image after UI is disabled
        screenshotcount++;
        foreach (Transform t in Canvastrig.transform)//for loop which reactivates the canvas
        {
            if (t.tag == "Canvas")
            {
                t.gameObject.SetActive(true);
            }
        }
        
    }

}
    

