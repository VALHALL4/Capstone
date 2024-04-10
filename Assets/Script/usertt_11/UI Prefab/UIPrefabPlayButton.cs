using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrefabPlayButton : MonoBehaviour
{
   public GameObject[] gameObject1 = new GameObject[27];
   public GameObject gameObject2;
   public GameObject gameObject3;
   public GameObject gameObject4;


    public Material mat1;
    public Material mat2;
    public Material mat3;

    public void ButtonClick()
    {
        for (int i = 0; i < 27; i++)
        {
            gameObject1[i].GetComponent<MeshRenderer>().material = mat1;
        }
     
        gameObject2.GetComponent<MeshRenderer>().material = mat2;
        gameObject3.GetComponent<MeshRenderer>().material = mat3;
        gameObject4.SetActive(true);
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Trilight;

    }
}
