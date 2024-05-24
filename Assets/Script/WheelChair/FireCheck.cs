using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class FireCheck : MonoBehaviour
{

    public GameObject warningUI;
    public TextMeshProUGUI instructionText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {   
            warningUI.SetActive(true);
            instructionText.color = new Color32(255, 0, 0, 255);
            instructionText.text = "WARNING";
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            warningUI.SetActive(false);
        }
    }
}

