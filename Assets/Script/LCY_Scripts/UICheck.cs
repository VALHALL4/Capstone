using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICheck : MonoBehaviour
{
    public GameObject uiGo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.uiGo.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.uiGo.SetActive(false);
        }
    }
}
