using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DisplayController : MonoBehaviour
{
    public SimpleConveyorBell conveyorBellOne;
    public SimpleConveyorBell conveyorBellTwo;
    
    public SimpleConveyorBell conveyorBellThree;
    public SimpleConveyorBell conveyorBellFour;
    
    public SimpleConveyorBell conveyorBellFive;
    public SimpleConveyorBell conveyorBellSix;
    
    public SimpleConveyorBell conveyorBellSeven;
    public SimpleConveyorBell conveyorBellEight;
    
    public SimpleConveyorBell conveyorBellNine;
    public SimpleConveyorBell conveyorBellTen;
    
    public SimpleConveyorBell conveyorBellEleven;
    public SimpleConveyorBell conveyorBellTwelve;
    
    public SimpleConveyorBell conveyorBellThirteen;
    public SimpleConveyorBell conveyorBellFourteen;
    
    public SimpleConveyorBell conveyorBellFifteen;
    public SimpleConveyorBell conveyorBellSixteen;
    
    public SimpleConveyorBell conveyorBellSeventeen;
    public SimpleConveyorBell conveyorBellEighteen;
    
    public SimpleConveyorBell conveyorBellNineteen;
    public SimpleConveyorBell conveyorBellTwenty;
    
    public SimpleConveyorBell conveyorBellTwentyOne;
    public SimpleConveyorBell conveyorBellTwentyTwo;
    
    public SimpleConveyorBell conveyorBellTwentyThree;
    public SimpleConveyorBell conveyorBellTwentyFour;
    
    public SimpleConveyorBell conveyorBellTwentyFive;
    public SimpleConveyorBell conveyorBellTwentySix;
    
    public SimpleConveyorBell conveyorBellTwentySeven;
    public SimpleConveyorBell conveyorBellTwentyEight;
    
    public void StartConveyorOne()
    {
        StartCoroutine(Wait(conveyorBellOne, conveyorBellTwo));
    }
    
    public void StartConveyorTwo()
    {
        StartCoroutine(Wait(conveyorBellThree, conveyorBellFour));
    }
    
    public void StartConveyorThree()
    {
        StartCoroutine(Wait(conveyorBellFive, conveyorBellSix));
    }
    
    public void StartConveyorFour()
    {
        StartCoroutine(Wait(conveyorBellSeven, conveyorBellEight));
    }
    
    public void StartConveyorFive()
    {
        StartCoroutine(Wait(conveyorBellNine, conveyorBellTen));
    }
    
    public void StartConveyorSix()
    {
        StartCoroutine(Wait(conveyorBellEleven, conveyorBellTwelve));
    }
    
    public void StartConveyorSeven()
    {
        StartCoroutine(Wait(conveyorBellThirteen, conveyorBellFourteen));
    }
    
    public void StartConveyorEight()
    {
        StartCoroutine(Wait(conveyorBellFifteen, conveyorBellSixteen));
    }
    
    public void StartConveyorNine()
    {
        StartCoroutine(Wait(conveyorBellSeventeen, conveyorBellEighteen));
    }
    
    public void StartConveyorTen()
    {
        StartCoroutine(Wait(conveyorBellNineteen, conveyorBellTwenty));
    }
    
    public void StartConveyorEleven()
    {
        StartCoroutine(Wait(conveyorBellTwentyOne, conveyorBellTwentyTwo));
    }
    
    public void StartConveyorTwelve()
    {
        StartCoroutine(Wait(conveyorBellTwentyThree, conveyorBellTwentyFour));
    }
    
    public void StartConveyorThirteen()
    {
        StartCoroutine(Wait(conveyorBellTwentyFive, conveyorBellTwentySix));
    }
    
    public void StartConveyorFourteen()
    {
        StartCoroutine(Wait(conveyorBellTwentySeven, conveyorBellTwentyEight));
    }
    

    IEnumerator Wait(SimpleConveyorBell conveyorBellOne, SimpleConveyorBell conveyorBellTwo)
    {
        conveyorBellOne.enabled = true;
        conveyorBellTwo.enabled = true;
        yield return new WaitForSecondsRealtime(2.5f);
        conveyorBellOne.enabled = false;
        conveyorBellTwo.enabled = false;
    }
    
}
