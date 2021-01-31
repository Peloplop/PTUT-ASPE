using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoSword;
    public AudioSource playSound;

    public void StartAutoSword()
    {
        playSound.Play();
        AutoSword.SetActive(true);
        GlobalCash.CashCount -= GlobalForge.forgeValue;
        GlobalForge.forgeValue *= 2;
        GlobalForge.turnOffButton = true;
        GlobalForge.forgePerSec += 1;
        GlobalForge.numberOfForges += 1;

    }
}
