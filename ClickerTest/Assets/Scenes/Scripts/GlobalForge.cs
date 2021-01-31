using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalForge : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash ;
    public static int forgeValue = 5;
    public static bool turnOffButton = false ;
    public GameObject forgeStats;
    public static int numberOfForges=0;
    public static int forgePerSec=0;


    void Update()
    {
        currentCash = GlobalCash.CashCount;
        forgeStats.GetComponent<Text>().text = "Forges: " + numberOfForges + " @ " + forgePerSec + " Per/Second";
        fakeText.GetComponent<Text>().text = "Buy Forge " + forgeValue + "$";
        realText.GetComponent<Text>().text = "Buy Forge " + forgeValue + "$";
        if (currentCash >= forgeValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true)
        {
            
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
