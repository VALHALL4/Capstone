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
        instructionText.text = "��ȭ�� ������ �κп� ��ġ�� �������� �̾��ּ���";
    }

    // �������� �̾��� �� ȣ��Ǵ� �޼���
    private void ChangeTextToStartSpraying()
    {
        instructionText.text = "���� ���� ȣ���� �����ϰ� ��ư�� ���� �л��ϼ���";
    }

    // �л縦 ������ �� ȣ��Ǵ� �޼���

    private void ChangeTextToEnd()
    {
        instructionText.text = "������ ��ô���ȭ�⸦ ����ϰڽ��ϴ�";       
        Invoke("ChangeTextStartTFE", 3.0f);
    }

    private void ChangeTextStartTFE()
    {
        instructionText.text = "��ô�� ��ȭ��� �غ���� �ʿ���� ����� ������ Ư�� ��ȭ���Դϴ�. ��ô�� ��ȭ�⸦ ��� ���� ���� ����������";
        Instantiate(TFE, TFErespawnpos);
        Instantiate(Fire, Firerespawnpos);
    }

    private void ChangeTextTFE()
    {
        instructionText.text = "�� ��ȭ�� ��� ����� ���������� ������� ȿ���� ���̰� �����մϴ�. ������ ��ȭ�� ������ �տ��ִ� ����â���� �о�ñ� �ٶ��ϴ�";
    }

}
