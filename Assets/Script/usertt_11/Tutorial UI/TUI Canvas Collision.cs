using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUICanvasCollision : MonoBehaviour
{

  
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Play_er"))
        {
            canvas.SetActive(false);
        }
    }
    //private void OnTriggerExit(Collider collider)
    //{
    //    if (collider.gameObject.CompareTag("Play_er"))
    //    {
    //        canvas.SetActive(true);
    //    }
    //}
}

