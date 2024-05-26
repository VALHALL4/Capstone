using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrefabPlayButton : MonoBehaviour
{

    public int countdownTime = 1;
    public GameObject[] gameObject1 = new GameObject[27];
   public GameObject gameObject2;
   public GameObject gameObject3;
   public GameObject gameObject4;

    public GameObject gameObject5;
    public Material mat1;
    public Material mat2;
    public Material mat3;

    public GameObject[] gameObject6 = new GameObject[6];
    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;
    public GameObject ob4;
    public GameObject ob5;
    public GameObject ob6;

   
    public Material omat3;
    public Material omat4;
    public Material omat5;
    public Material omat6;

    public GameObject WallCover1;
    public GameObject UI;
    public void CountDown()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            yield return new WaitForSeconds(1f);

            countdownTime--;
        }


        UI.SetActive(false);


    }
    public void ButtonClick()
    {
        GetComponent<AudioSource>().Play();
        for (int i = 0; i < 20; i++)
        {
            gameObject1[i].GetComponent<MeshRenderer>().material = mat1;
        }
        for (int i = 20; i < 27; i++)
        {
            gameObject1[i].GetComponent<MeshRenderer>().material = mat2;
        }
        for (int i = 0; i < 6; i++)
        {
            gameObject6[i].SetActive(true);
        }
        gameObject2.GetComponent<MeshRenderer>().material = mat1;
        gameObject3.GetComponent<MeshRenderer>().material = mat1;
        gameObject5.GetComponent<MeshRenderer>().material = mat3;
        gameObject4.SetActive(true);

      
        ob3.GetComponent<MeshRenderer>().material = omat3;


        ob4.GetComponent<MeshRenderer>().material = omat4;
        ob5.GetComponent<MeshRenderer>().material = omat5;
        ob6.GetComponent<MeshRenderer>().material = omat6;


        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Trilight;
        WallCover1.SetActive(false);
        CountDown();
        

    }
}
