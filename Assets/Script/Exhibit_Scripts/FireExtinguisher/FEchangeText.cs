using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FEchangeText : MonoBehaviour
{
   public TextMeshProUGUI instructionText;

    private void OnEnable()
    {
        FireExtinguisher.OnFireExtinguisherGrabbed += ChangeTextToSafetyPin;
        PullOutPin.OnSafetyPinPulled += ChangeTextToStartSpraying;
        FireExtinguisher.OnStartSpraying += ChangeTextToEnd;
    }
    private void OnDisable()
    {
        FireExtinguisher.OnFireExtinguisherGrabbed -= ChangeTextToSafetyPin;
        PullOutPin.OnSafetyPinPulled -= ChangeTextToStartSpraying;
        FireExtinguisher.OnStartSpraying -= ChangeTextToEnd;
    }

    private void Start()
    {
        instructionText.color = new Color32(0, 0, 0, 255);
        
    }
    private void ChangeTextToSafetyPin()
    {
        instructionText.text = "�������� �̽��ϴ�.";
    }

    // �������� �̾��� �� ȣ��Ǵ� �޼���
    private void ChangeTextToStartSpraying()
    {
        instructionText.text = "���� ���Ͽ� ȣ���� �����ϰ� ��ư�� ���� �л��ϼ���.";
    }

    // �л縦 ������ �� ȣ��Ǵ� �޼���
    private void ChangeTextToEnd()
    {
        instructionText.text = "���߽��ϴ�. ��ȭ�� ü���� �Ϸ�Ǿ����ϴ�.";
    }

}
