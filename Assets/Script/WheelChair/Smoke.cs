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
            Debug.Log("VRHead ����");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("VRHead"))
        {
            this.elapsedTime += Time.deltaTime;
            if(this.elapsedTime >= 5f)
            {
                //5�� �̻� �Ǿ��� ��
                warningUI.SetActive(true);
                instructionText.color = new Color32(255, 0, 0, 255);
                instructionText.text = "WARNING";
                Debug.LogFormat("<color=red>ȭ�翬�⸦ 5���̻� ���̽��ϴ�.</color>");
                this.elapsedTime = 0f; //�ð� �ʱ�ȭ
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("VRHead"))
        {
            Debug.Log("VRHead ����");
            warningUI.SetActive(false);
            this.elapsedTime = 0f;
        }
    }
}
