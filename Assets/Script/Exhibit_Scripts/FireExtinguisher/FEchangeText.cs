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
        instructionText.text = "안전핀을 뽑습니다.";
    }

    // 안전핀을 뽑았을 때 호출되는 메서드
    private void ChangeTextToStartSpraying()
    {
        instructionText.text = "불을 향하여 호스를 조준하고 버튼을 눌러 분사하세요.";
    }

    // 분사를 시작할 때 호출되는 메서드
    private void ChangeTextToEnd()
    {
        instructionText.text = "잘했습니다. 소화기 체험이 완료되었습니다.";
    }

}
