using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand2Print : MonoBehaviour
{

    public AnimationScript animationScript;

    public void Event1()
    {
        animationScript.EnableHandPrint();
    }

    public void HandPlaced()
    {
        animationScript.HandPlaced();
    }

}
