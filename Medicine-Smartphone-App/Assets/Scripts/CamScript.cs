using System.Collections;
using UnityEngine;
using ZXing;
using System;
using TMPro;

public class CamScript : MonoBehaviour
{
    public GameObject QRParent;
    public GameObject ConnectionPage;

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
                    StopAllCoroutines();
                    StartCoroutine(ReturnToConnectioWithDelay(10));
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

    IEnumerator ReturnToConnectioWithDelay(int time)
    {
        yield return new WaitForSecondsRealtime(time);
        QRParent.SetActive(false);
        ConnectionPage.SetActive(true);
    }
}