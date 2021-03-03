using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RegisterManager : MonoBehaviour
{
    public string url = "http://locahost/sqlconnect/reister.php";

    public TMP_InputField emailField;
    public TMP_InputField nameField;
    public TMP_InputField passField;
    public TMP_InputField repeatPassField;

    public Button submitButton;

    public void CallReigster()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", emailField.text);
        form.AddField("username", nameField.text);
        form.AddField("password", passField.text);
        form.AddField("repeatPassword", repeatPassField.text);

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
                Debug.Log("User created");
            }
            else
            {
                Debug.LogWarning("User not created. Error #" + www.downloadHandler.text);
            }
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable =
            (nameField.text.Length >= 3 && passField.text.Length >= 7 && repeatPassField.text.Length >= 7);
    }
}