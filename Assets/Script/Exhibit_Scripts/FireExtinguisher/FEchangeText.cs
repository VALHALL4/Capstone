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

    public AudioClip[] audioClips;
    private AudioSource audioSource;
    private int audioIndex = 0;
    public GameObject canvas;


    private bool safetyPinPulled = false;
    private bool startSpraying = false;
    private bool fireExtinguisherThrown = false;

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
        audioSource = GetComponent<AudioSource>();
        
    }

    private void playAudio()
    {
        if(audioIndex < audioClips.Length)
        {
            audioSource.clip = audioClips[audioIndex];
            audioSource.Play();
            audioIndex++;
        }
    }
    //��ȭ�⸦ �������
    private void ChangeTextToSafetyPin()
    {
        if (!safetyPinPulled && !startSpraying && !fireExtinguisherThrown)
        {
            firstPreview.SetActive(false);
            secondPreview.SetActive(true);
            instructionText.text = "��ȭ�� ������ �κп� ��ġ�� �������� �̾��ּ���";
            playAudio();
            safetyPinPulled = true;
        }
    }

    // �������� �̾��� �� ȣ��Ǵ� �޼���
    private void ChangeTextToStartSpraying()
    {
        if (safetyPinPulled && !startSpraying && !fireExtinguisherThrown)
        {
            secondPreview.SetActive(false);
            instructionText.text = "���� ���� ȣ���� �����ϰ� ��ư�� ���� �л��ϼ���";
            playAudio();
            startSpraying = true;
        }
    }

    // �л縦 ������ �� ȣ��Ǵ� �޼���

    private void ChangeTextToEnd()
    {
        if (safetyPinPulled && startSpraying && !fireExtinguisherThrown)
        {
            instructionText.text = "������ ��ô���ȭ�⸦ ����ϰڽ��ϴ�";
            Invoke("ChangeTextStartTFE", 3.0f);
            playAudio();
        }
    }

    private void ChangeTextStartTFE()
    {
        if (safetyPinPulled && startSpraying && !fireExtinguisherThrown)
        {
            instructionText.text = "��ô�� ��ȭ��� �غ���� �ʿ���� ����� ������ Ư�� ��ȭ���Դϴ�. ��ô�� ��ȭ�⸦ ��� ���� ���� ����������";
            Instantiate(TFE, TFErespawnpos);
            Instantiate(Fire, Firerespawnpos);
            playAudio();
        }
    }

        private void ChangeTextTFE()
    {
        if (safetyPinPulled && startSpraying && !fireExtinguisherThrown)
        {
            instructionText.text = "�� ��ȭ�� ��� ����� ���������� ������� ȿ���� ���̰� �����մϴ�. ������ ��ȭ�� ������ �տ��ִ� ����â���� �о�ñ� �ٶ��ϴ�";
            playAudio();
            canvas.SetActive(true);
        }
    }

}
