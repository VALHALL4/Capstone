using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrefabPlayButton : MonoBehaviour
{
    public Material skyboxMaterial;
 
    public void ButtonClick()
    {
        RenderSettings.skybox = skyboxMaterial;
       
    }
}
