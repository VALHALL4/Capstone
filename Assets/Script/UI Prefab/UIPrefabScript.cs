using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrefabScript : MonoBehaviour
{
    private Vector3 dir;
    public Transform camera;
    int count = 0;

    private bool turns = false;
    private bool turnb = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distCamera();
    }

    public void small ()
    {
        transform.localScale = new Vector3 ( transform.localScale.x * (0.97f), transform.localScale.y * (0.97f) , transform.localScale.z);
        Debug.Log(count);
        if (count < 100)
        {
            Invoke("small", 0.01f);
            count++;
        }
        else if (count == 100)
        {
            count = 0;
            turnb = false;
        }
        

    }
    public void big()
    {
        transform.localScale = new Vector3(transform.localScale.x * (1.03f), transform.localScale.y * (1.03f), transform.localScale.z);
        Debug.Log(count);
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
       
        float distance = Vector3.Distance(camera.position, transform.position);

        if (distance <= 1.0f)
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
              
                    Invoke("big", 0.01f);
                turnb = true;
                

            }
        }

    }
}
