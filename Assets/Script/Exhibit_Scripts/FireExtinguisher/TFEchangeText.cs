using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TFEchangeText : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    private void OnEnable()
    {
        ThrowFireExitinguisher.OnFireExtinguisherThrow += ChangeTextTFE;
    }
    private void OnDisable()
    {
        ThrowFireExitinguisher.OnFireExtinguisherThrow -= ChangeTextTFE;
    }

    private void Start()
    {
        instructionText.color = new Color32(0, 0, 0, 255);

    }
    private void ChangeTextTFE()
    {
        instructionText.text = "투척용 소화기는 사용법이 간단하여\n 몸이 불편하신분들이나 노인, \n 어린이등 모두가 손쉽게 사용할 수 있습니다.";
           

    }
}
