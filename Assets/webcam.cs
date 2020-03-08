using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Webcam : MonoBehaviour {

    // http://answers.unity3d.com/questions/909967/getting-a-web-cam-to-play-on-ui-texture-image.html

    // http://answers.unity3d.com/questions/451755/how-do-i-access-two-webcams-simultaneously.html

    public RawImage rawimage;
    public int WebcamIndex = 0;
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();

        for (var i = 0; i < WebCamTexture.devices.Length; ++i)
        {
            Debug.Log(WebCamTexture.devices[i].name + " WebcamIndex:" + i);
        } 

        webcamTexture.deviceName = WebCamTexture.devices[WebcamIndex].name;
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
