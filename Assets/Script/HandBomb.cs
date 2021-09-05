using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBomb : MonoBehaviour
{
    public AnimationScript animationScript;

   public void Event1()
    {
        animationScript.EnableBombPrint1();
    }

    public void Event2()
    {
        animationScript.EnableBombPrint2();
    }

    public void BombPlaced()
    {
        animationScript.BombPlaced();
    }
   
    public void StartPouring()
    {
        animationScript.StartPouring();
    }
}
