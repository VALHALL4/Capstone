using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUICanvasCollision : MonoBehaviour
{
    public GameObject canvas;

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

