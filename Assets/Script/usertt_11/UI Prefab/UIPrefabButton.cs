using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPrefabButton : MonoBehaviour
{

   

    public void ButtonClick()
    {
        SceneManager.LoadScene("FlashLightZone");
    }
}
