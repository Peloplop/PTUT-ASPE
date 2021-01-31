using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public AudioSource swordOne;
    public AudioSource swordTwo;
    public int generateToneSword;

    public void ClickTheButton ()
    {
        generateToneSword = Random.Range(1, 3);
        GlobalSword.SwordCount += 1;
        if (generateToneSword == 1)
        {
            swordOne.Play();
        }
        else
        {
            swordTwo.Play();
        }
    }

}
