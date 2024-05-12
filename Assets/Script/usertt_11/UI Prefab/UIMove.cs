using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMove : MonoBehaviour
{
   
    public void ButtonClick()
    {
        if (gameObject.CompareTag("FlashLightZone"))
        {
            SceneManager.LoadScene("FlashLightZone");

        }
        else if (gameObject.CompareTag("FE Experience Scene"))
        {
            SceneManager.LoadScene("FE Experience Scene");

        }
        else if (gameObject.CompareTag("PlayScene"))
        {
            SceneManager.LoadScene("Experience Scene");

        }
        else if (gameObject.CompareTag("EscapeArea"))
        {
            SceneManager.LoadScene("RefugeAreaScene");

        }
    }

}
