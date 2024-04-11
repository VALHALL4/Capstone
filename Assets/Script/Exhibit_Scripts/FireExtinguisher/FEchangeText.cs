using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FEchangeText : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    public GameObject TFE;
    public Transform TFErespawnpos;
    public GameObject Fire;
    public Transform Firerespawnpos;

    private void OnEnable()
    {
        FireExtinguisher.OnFireExtinguisherGrabbed += ChangeTextToSafetyPin;
        PullOutPin.OnSafetyPinPulled += ChangeTextToStartSpraying;
        FireExtinguisher.OnStartSpraying += ChangeTextToEnd;
        ThrowFireExitinguisher.OnFireExtinguisherThrow += ChangeTextTFE;
    }
    private void OnDisable()
    {
        FireExtinguisher.OnFireExtinguisherGrabbed -= ChangeTextToSafetyPin;
        PullOutPin.OnSafetyPinPulled -= ChangeTextToStartSpraying;
        FireExtinguisher.OnStartSpraying -= ChangeTextToEnd;
        ThrowFireExitinguisher.OnFireExtinguisherThrow -= ChangeTextTFE;
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
        Invoke("ChangeTextStartTFE", 3.0f);
    }

    private void ChangeTextStartTFE()
    {
        instructionText.text = "이번에는 투척용 소화기를 체험해보겠습니다.";
        Instantiate(TFE, TFErespawnpos);
        Instantiate(Fire, Firerespawnpos);
    }
    private void ChangeTextTFE()
    {
        instructionText.text = "투척용 소화기는 사용법이 간단하여\n 몸이 불편하신분들이나 노인, \n 어린이등 모두가 손쉽게 사용할 수 있습니다.";


    }

}
