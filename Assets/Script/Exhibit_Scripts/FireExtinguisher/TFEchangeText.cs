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
        instructionText.text = "��ô�� ��ȭ��� ������ �����Ͽ�\n ���� �����Ͻźе��̳� ����, \n ��̵� ��ΰ� �ս��� ����� �� �ֽ��ϴ�.";
           

    }
}
