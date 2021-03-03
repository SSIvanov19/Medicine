using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class AppManager : MonoBehaviour
{
    public Locale BGLocale;
    public Locale ENLocale;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Application.systemLanguage == SystemLanguage.Bulgarian)
        {
            LocalizationSettings.SelectedLocale = BGLocale;
        }
        else
        {
            LocalizationSettings.SelectedLocale = ENLocale;
            Debug.Log("en");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
