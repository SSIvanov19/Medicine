using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public GameObject medicinePicker;
    public GameObject confirmationScreen;
    public GameObject thanksScreen;
    public GameObject welcomeScreen;
    public GameObject helpScreen;
    public GameObject DNA;

    public GameObject medicine1;
    public GameObject medicine2;
    public GameObject medicine3;
    
    private int selectedMedicine;
    private bool helpShow = false;
    private bool isSmartphone = false;
    
    // Start is called before the first frame update
    void Start()
    {
        selectedMedicine = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContinueWithSmartphone()
    {
        isSmartphone = true;
        welcomeScreen.SetActive(false);
        DNA.SetActive(false);
        confirmationScreen.SetActive(true);
        
        selectedMedicine = 1;

        if (selectedMedicine == 1)
        {
            medicine1.SetActive(true);
        }
        else if(selectedMedicine == 2)
        {
            medicine2.SetActive(true);
        }
        else if (selectedMedicine == 3)
        {
            medicine3.SetActive(true);
        }
    }
    
    public void ContinueWithoutSmartphone()
    {
        isSmartphone = false;
        welcomeScreen.SetActive(false);
        DNA.SetActive(false);
        medicinePicker.SetActive(true);
        
        medicine1.SetActive(true);
    }

    public void ShowHelp()
    {
        helpShow = !helpShow;
        helpScreen.SetActive(helpShow);
    }

    public void BackToWelcome()
    {
        welcomeScreen.SetActive(true);
        DNA.SetActive(true);
        medicinePicker.SetActive(false);
        
        if (selectedMedicine == 1)
        {
            medicine1.GetComponent<Rotator>().Reset();
            medicine1.SetActive(false);
        }
        else if(selectedMedicine == 2)
        {
            medicine2.GetComponent<Rotator>().Reset();
            medicine2.SetActive(false);
        }
        else if (selectedMedicine == 3)
        {
            medicine3.GetComponent<Rotator>().Reset();
            medicine3.SetActive(false);
        }
    }

    public void ContinueToConfirmation()
    {
        if (selectedMedicine == 1)
        {
            medicine1.GetComponent<Rotator>().Reset();
        }
        else if(selectedMedicine == 2)
        {
            medicine2.GetComponent<Rotator>().Reset();
        }
        else if (selectedMedicine == 3)
        {
            medicine3.GetComponent<Rotator>().Reset();
        }
        
        medicinePicker.SetActive(false);
        confirmationScreen.SetActive(true);
    }

    public void NextMedicine()
    {
        if (selectedMedicine == 1)
        {
            medicine1.GetComponent<Rotator>().Reset();
            medicine1.SetActive(false);
            selectedMedicine = 2;
            medicine2.SetActive(true);
        }
        else if(selectedMedicine == 2)
        {
            medicine2.GetComponent<Rotator>().Reset();
            medicine2.SetActive(false);
            selectedMedicine = 3;
            medicine3.SetActive(true);
        }
        else if (selectedMedicine == 3)
        {
            medicine3.GetComponent<Rotator>().Reset();
            medicine3.SetActive(false);
            selectedMedicine = 1;
            medicine1.SetActive(true );
        }
    }
    
    public void PrevMedicine()
    {
        if (selectedMedicine == 1)
        {
            medicine1.GetComponent<Rotator>().Reset();
            medicine1.SetActive(false);
            selectedMedicine = 3;
            medicine3.SetActive(true);
        }
        else if(selectedMedicine == 2)
        {
            medicine2.GetComponent<Rotator>().Reset();
            medicine2.SetActive(false);
            selectedMedicine = 1;
            medicine1.SetActive(true);
        }
        else if (selectedMedicine == 3)
        {
            medicine3.GetComponent<Rotator>().Reset();
            medicine3.SetActive(false);
            selectedMedicine = 2;
            medicine2.SetActive(true );
        }
    }

    public void backToChoise()
    {
        if (isSmartphone)
        {
            confirmationScreen.SetActive(false);
            
            if (selectedMedicine == 1)
            {
                medicine1.GetComponent<Rotator>().Reset();
                medicine1.SetActive(false);
            }
            else if(selectedMedicine == 2)
            {
                medicine2.GetComponent<Rotator>().Reset();
                medicine2.SetActive(false);
            }
            else if (selectedMedicine == 3)
            {
                medicine3.GetComponent<Rotator>().Reset();
                medicine3.SetActive(false);
            }
            
            welcomeScreen.SetActive(true);
        }
        else
        {
            confirmationScreen.SetActive(false);
            
            if (selectedMedicine == 1)
            {
                medicine1.GetComponent<Rotator>().Reset();
            }
            else if(selectedMedicine == 2)
            {
                medicine2.GetComponent<Rotator>().Reset();
            }
            else if (selectedMedicine == 3)
            {
                medicine3.GetComponent<Rotator>().Reset();
            }
            
            medicinePicker.SetActive(true);
        }
    }

    public void ProcedToCheckout()
    {
        confirmationScreen.SetActive(false);
            
        if (selectedMedicine == 1)
        {
            medicine1.GetComponent<Rotator>().Reset();
            medicine1.SetActive(false);
        }
        else if(selectedMedicine == 2)
        {
            medicine2.GetComponent<Rotator>().Reset();
            medicine2.SetActive(false);
        }
        else if (selectedMedicine == 3)
        {
            medicine3.GetComponent<Rotator>().Reset();
            medicine3.SetActive(false);
        }
        
        thanksScreen.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(WaitForSeconds(10));
    }
    
    IEnumerator WaitForSeconds(int time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene(0);
    }
}
