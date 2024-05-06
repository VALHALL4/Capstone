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

    public GameObject firstPreview;
    public GameObject secondPreview;

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
        firstPreview.SetActive(false);
        secondPreview.SetActive(true);
        instructionText.text = "소화기 손잡이 부분에 위치한 안전핀을 뽑아주세요";
    }

    // 안전핀을 뽑았을 때 호출되는 메서드
    private void ChangeTextToStartSpraying()
    {
        secondPreview.SetActive(false);
        instructionText.text = "불을 향해 호스를 조준하고 버튼을 눌러 분사하세요";
    }

    // 분사를 시작할 때 호출되는 메서드

    private void ChangeTextToEnd()
    {
        instructionText.text = "다음은 투척용소화기를 사용하겠습니다";       
        Invoke("ChangeTextStartTFE", 3.0f);
    }

    private void ChangeTextStartTFE()
    {
        instructionText.text = "투척용 소화기는 준비과정 필요없이 사용이 가능한 특수 소화기입니다. 투척용 소화기를 들고 불을 향해 던져보세요";
        Instantiate(TFE, TFErespawnpos);
        Instantiate(Fire, Firerespawnpos);
    }

    private void ChangeTextTFE()
    {
        instructionText.text = "두 소화기 모두 기능은 동일하지만 사용방법과 효과에 차이가 존재합니다. 각각의 소화기 정보는 앞에있는 정보창에서 읽어보시길 바랍니다";
    }

}
