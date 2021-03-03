using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.SocialPlatforms;

public class LanguageScript : MonoBehaviour
{
    public Sprite BGFlagIcon;
    public Sprite UKFlagIcon;
    
    public bool isBulgarianLanguage = true;

    public Locale BGLocale;
    public Locale ENLocale;
    
    private Image image;
    
    private void Start()
    {
        image = gameObject.GetComponent<Image>();
    }

    public void ChangeLanguage()
    {
        if (isBulgarianLanguage)
        {
            image.sprite = BGFlagIcon;
            LocalizationSettings.SelectedLocale = ENLocale;
            isBulgarianLanguage = false;
        }
        else
        {
            image.sprite = UKFlagIcon;
            LocalizationSettings.SelectedLocale = BGLocale;
            isBulgarianLanguage = true;
        }
    }
}
