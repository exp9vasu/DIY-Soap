using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HandPackWick : MonoBehaviour
{
    public AnimationScript animationScript;

    public void FillPlane()
    {
        animationScript.FillPlane();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
