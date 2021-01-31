using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellSword : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public AudioSource noSword;
    public int generateTone;

    public void ClickTheButton ()
    {
        generateTone = Random.Range(1, 3);
        if (GlobalSword.SwordCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough Swords to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            noSword.Play();
        }
        else
        {
            GlobalSword.SwordCount -= 1;
            GlobalCash.CashCount += 1;
            if (generateTone == 1)
            {
                cashOne.Play();
            }
            else
            {
                cashTwo.Play();
            }
        }
    }

}
