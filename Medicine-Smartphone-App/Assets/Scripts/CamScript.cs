using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using ZXing.QrCode;
using System;
using TMPro;

public class CamScript : MonoBehaviour
{
    public RectTransform rectToMatch;
    public TextMeshProUGUI tagOutputText;
    public TextMeshProUGUI debugOutputText;
    
    private WebCamTexture webCameraTexture;

    private int frames = 0;
    // Start is called before the first frame update
    void Start()
    {
        webCameraTexture = new WebCamTexture();
        GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if (frames == 30)
        {
            try
            {
                IBarcodeReader barcodeReader = new BarcodeReader();

                // decode the current frame
                var result = barcodeReader.Decode(webCameraTexture.GetPixels32(), webCameraTexture.width,
                    webCameraTexture.height);
                if (result != null)
                {
                    tagOutputText.text = "DECODED TEXT FROM QR: " + result.Text;
                }
                else
                {
                    debugOutputText.text = "null";
                }
            }
            catch (Exception ex)
            {
                debugOutputText.text = ex.Message;
            }

            frames = 0;
        }
    }
}
