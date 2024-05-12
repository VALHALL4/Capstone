using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPrefabScript : MonoBehaviour
{
    private Vector3 dir;
    public Transform mainCamera;
    public float dist = 1.0f;
    int count = 0;
    public GameObject panel;
    public GameObject text;

    private bool turns = false;
    private bool turnb = true;

    // Update is called once per frame
    void Update()
    {
        distCamera();
    }

    public void small ()
    {
        transform.localScale = new Vector3 ( transform.localScale.x * (0.97f), transform.localScale.y * (0.97f) , transform.localScale.z);
        if (count < 100)
        {
            Invoke("small", 0.01f);
            count++;
        }

        else if (count == 100)
        {
            count = 0;
            turnb = false;
            panel.SetActive(false);
            text.SetActive(false);
        }
    }

    public void big()
    {
        transform.localScale = new Vector3(transform.localScale.x * (1.03f), transform.localScale.y * (1.03f), transform.localScale.z);

        if (count < 100)
        {
            Invoke("big", 0.01f);
            count++;
        }

        else if (count == 100)
        {
            count = 0;
            turns = false;
        }
    }

    public void distCamera()
    {
        float distance = Vector3.Distance(mainCamera.position, transform.position);

        if (distance >= dist)
        {
            if(turns == false)
            {
                Invoke("small" , 0.01f);
                turns = true;
            }
        }

        else
        {
            if (turnb == false )
            {
                panel.SetActive(true);
                text.SetActive(true);
                Invoke("big", 0.01f);
                turnb = true;
            }
        }
    }
}
