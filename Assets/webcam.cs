using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class webcam : MonoBehaviour {

    // http://answers.unity3d.com/questions/909967/getting-a-web-cam-to-play-on-ui-texture-image.html

    // http://answers.unity3d.com/questions/451755/how-do-i-access-two-webcams-simultaneously.html

    public RawImage rawimage;
    public int WebcamIndex = 0;
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();

        foreach (var webCamDevice in WebCamTexture.devices)
        {
            Debug.Log(webCamDevice.name);
        }

         webcamTexture.deviceName = WebCamTexture.devices[WebcamIndex].name;
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
