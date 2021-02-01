using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSCounterDisplay : MonoBehaviour
{
    
    public float timer, refresh, avgFramerate;
    string display = "{0}";
    private TextMeshProUGUI displayText;
 
    private void Start()
    {
        displayText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        //Change smoothDeltaTime to deltaTime or fixedDeltaTime to see the difference
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;
 
        if(timer <= 0) avgFramerate = (int) (1f / timelapse);
        {
            displayText.text = "FPS: " + string.Format(display, avgFramerate.ToString());
        }
    }
}