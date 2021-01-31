using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disasters : MonoBehaviour
{
    public GameObject statusBox;
    public float SwordCheck;
    public int genChance;
    public bool disasterActive = false ;
    public int swordLoss;

    void Start ()
    {
        statusBox.GetComponent<Text>().text = "  ";
    }
    
    void Update()
    {
        SwordCheck = GlobalSword.SwordCount / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }

    }
    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        if (SwordCheck >= genChance)
        {
            swordLoss = Mathf.RoundToInt(GlobalSword.SwordCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + swordLoss + " swords to thieves.";
            GlobalSword.SwordCount -= swordLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }

}

