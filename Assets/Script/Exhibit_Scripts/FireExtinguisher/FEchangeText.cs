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
        instructionText.text = "2. 소화기 손잡이 부분에 위치한 안전핀을 뽑아주세요";
    }

    // 안전핀을 뽑았을 때 호출되는 메서드
    private void ChangeTextToStartSpraying()
    {
        instructionText.text = "3. 불을 향해 호스를 조준하고 버튼을 눌러 분사하세요";
    }

    // 분사를 시작할 때 호출되는 메서드

    private void ChangeTextToEnd()
    {
        instructionText.text = "잘하셨습니다. 다음은 투척용소화기에 대해 설명해드리겠습니다";       
        Invoke("ChangeTextStartTFE", 3.0f);
    }

    private void ChangeTextStartTFE()
    {
        instructionText.text = "투척용 소화기는 준비과정이 필요없이 화재가 난 곳에 던지면 되는 특수 소화기입니다 투척용 소화기를 들고 불을 향해 던져보세요";
        Instantiate(TFE, TFErespawnpos);
        Instantiate(Fire, Firerespawnpos);
    }

    private void ChangeTextTFE()
    {
        instructionText.text = "잘하셨습니다! 이처럼 투척용 소화기는 사용법이 간단하여 몸이 불편하신분들이나 노인, 어린이등 모두가 손쉽게 사용할 수 있습니다";
    }

}
