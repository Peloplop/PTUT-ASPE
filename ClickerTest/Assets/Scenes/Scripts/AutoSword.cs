using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSword : MonoBehaviour
{
    public bool CreatingSword = false;
    public static int SwordIncrease = 1;
    public int InternalIncrease ;
    
    void Update()
    {
        SwordIncrease = GlobalForge.forgePerSec;
        InternalIncrease = SwordIncrease;
        if (CreatingSword == false)
        {
            CreatingSword = true;
            StartCoroutine(CreateTheSword());
        }

    }
    IEnumerator CreateTheSword ()
    {
        GlobalSword.SwordCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingSword = false;
    }
}
