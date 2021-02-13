using System;
using UnityEngine;
using TMPro;

public class NFC : MonoBehaviour
{
    public string tagID;
    public TextMeshProUGUI tagOutputText;
    public TextMeshProUGUI debugOutputText;
    public bool tagFound = false;

    private AndroidJavaObject mActivity;
    private AndroidJavaObject mIntent;
    private string sAction;

    void Start()
    {
        tagOutputText.text = "Scan a NFC tag to show ID";
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (!tagFound)
            {
                try
                {
                    // Create new NFC Android object
                    mActivity =
                        new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>(
                            "currentActivity"); 
                    mIntent = mActivity.Call<AndroidJavaObject>("getIntent");
                    sAction = mIntent.Call<String>("getAction"); 

                    if (sAction == "android.nfc.action.NDEF_DISCOVERED")
                    {
                        debugOutputText.text = "Tag of type NDEF";
                    }
                    else if (sAction == "android.nfc.action.TECH_DISCOVERED")
                    {
                        debugOutputText.text = "TAG DISCOVERED";
                        
                        // Get ID of tag
                        AndroidJavaObject mNdefMessage =
                            mIntent.Call<AndroidJavaObject>("getParcelableExtra", "android.nfc.extra.TAG");
                        
                        if (mNdefMessage != null)
                        {
                            var payLoad = mNdefMessage.Call<byte[]>("getId");
                            var text = System.Convert.ToBase64String(payLoad);
                            
                            tagOutputText.text += "This is your tag text: " + text;
                            tagID = text;
                        }
                        else
                        {
                            tagOutputText.text = "No ID found !";
                        }
                        
                        tagFound = true;
                    }
                    else if (sAction == "android.nfc.action.TAG_DISCOVERED")
                    {
<<<<<<< HEAD
                        debugOutputText.text = "This type of tag is not supported !";
=======
                        Debug.Log("This type of tag is not supported !");
>>>>>>> 08f1b718a4c812eb39e413d4cb932e21133f26f6
                    }
                    else
                    {
                        tagOutputText.text = "Scan a NFC tag to show ID";
                    }
                }
                catch (Exception ex)
                {
                    var text = ex.Message;
<<<<<<< HEAD
                    debugOutputText.text = "Catch";
                }
            }
=======
                    tagOutputText.text = text;
                }
            }
            else
            {
                debugOutputText.text = "No NFC found";
            }
>>>>>>> 08f1b718a4c812eb39e413d4cb932e21133f26f6
        }
        else
        {
            debugOutputText.text = "Not Android Platform";
        }
    }
}