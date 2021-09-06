using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScript : MonoBehaviour
{
    public AnimationScript animationScript;

    public void StartObiFluid()
    {
        animationScript.StartObiFluid();
    }

    public void PutWick()
    {
        animationScript.WickPut();
    }
}
