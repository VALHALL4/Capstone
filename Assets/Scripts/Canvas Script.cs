using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public GameObject button;
    public GameObject indicator; 


// Start is called before the first frame update
void Start()
    {
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (indicator.CompareTag("active"))
        {
            button.SetActive(true);
            
        }
    }
}
