using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSword : MonoBehaviour
{

    public static int SwordCount;
    public GameObject SwordDisplay;
    public int InternalSword;

    void Update()
    {
        InternalSword = SwordCount;
        SwordDisplay.GetComponent<Text>().text = "Swords: " + InternalSword;
    }
}
