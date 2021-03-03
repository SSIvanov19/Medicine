using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string url = "http://locahost/sqlconnect/login.php";
    
    public TMP_InputField nameField;
    public TMP_InputField passField;
    
    public Button submitButton;

    
    public void CallLogin()
    {
        StartCoroutine(Login());
    }
    
    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passField.text);

        UnityWebRequest www = UnityWebRequest.Post(url, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError ||
            www.result == UnityWebRequest.Result.ProtocolError ||
            www.result == UnityWebRequest.Result.DataProcessingError)
        {
            Debug.LogWarning(www.error);
        }
        else
        {
            if (www.downloadHandler.text[0] == '0')
            {
                DBManager.Username = nameField.text;
                DBManager.ID = int.Parse(www.downloadHandler.text.Split('\t')[1]);
                Debug.Log("Log in");
            }
            else
            {
                Debug.LogWarning("Not log in. Error #" + www.downloadHandler.text);
            }
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable =
            (nameField.text.Length >= 3 && passField.text.Length >= 7);
    }
}
