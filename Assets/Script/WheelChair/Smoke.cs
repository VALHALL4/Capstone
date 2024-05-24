using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    private float elapsedTime = 0f;
    public GameObject warningUI;
    public TextMeshProUGUI instructionText;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("VRHead"))
        {
            Debug.Log("VRHead 들어옴");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("VRHead"))
        {
            this.elapsedTime += Time.deltaTime;
            if(this.elapsedTime >= 5f)
            {
                //5초 이상 되었을 시
                warningUI.SetActive(true);
                instructionText.color = new Color32(255, 0, 0, 255);
                instructionText.text = "WARNING";
                Debug.LogFormat("<color=red>화재연기를 5초이상 마셨습니다.</color>");
                this.elapsedTime = 0f; //시간 초기화
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("VRHead"))
        {
            Debug.Log("VRHead 나감");
            warningUI.SetActive(false);
            this.elapsedTime = 0f;
        }
    }
}
