using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FEchangeText : MonoBehaviour
{
    [SerializeField]
    private Image dim;
    [SerializeField]
    private GameObject canvasGo;

    public TextMeshProUGUI instructionText;
    public GameObject TFE;
    public Transform TFErespawnpos;
    //public GameObject Fire;
    public GameObject Firerespawnpos;

    public GameObject firstPreview;
    public GameObject secondPreview;

    public AudioClip[] audioClips;
    private AudioSource audioSource;
    private int audioIndex = 0;
    public GameObject canvas;


    private bool safetyPinPulled = false;
    private bool startSpraying = false;
    private bool fireExtinguisherThrown = false;
    private bool FEend = false;
    public bool FEended
    {
        get { return FEend; }
    }


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
        if (audioIndex < audioClips.Length)
        {
            audioSource.clip = audioClips[audioIndex];
            audioSource.Play();
            audioIndex++;
        }
    }
    //��ȭ�⸦ �������
    private void ChangeTextToSafetyPin()
    {
        if (!safetyPinPulled && !startSpraying && !fireExtinguisherThrown && this != null)
        {
            //firstPreview.SetActive(false);
            //secondPreview.SetActive(true);
            instructionText.text = "��ȭ�� ������ �κп� ��ġ�� �������� �̾��ּ���";
            playAudio();
            safetyPinPulled = true;
        }
    }

    // �������� �̾��� �� ȣ��Ǵ� �޼���
    private void ChangeTextToStartSpraying()
    {
        if (safetyPinPulled && !startSpraying && !fireExtinguisherThrown && this != null)
        {
            //secondPreview.SetActive(false);//destory �Ǹ� ������ ������Ʈ�� ������� ���� �Ұ�
            instructionText.text = "���� ���� ȣ���� �����ϰ� ��ư�� ���� �л��ϼ���";
            playAudio();
            startSpraying = true;
        }
    }

    // �л縦 ������ �� ȣ��Ǵ� �޼���

    private void ChangeTextToEnd()
    {
        if (safetyPinPulled && startSpraying && !fireExtinguisherThrown && this != null)
        {
            instructionText.text = "������ ��ô���ȭ�⸦ ����ϰڽ��ϴ�";
            Invoke("ChangeTextStartTFE", 3.0f);
            playAudio();
            FEend = true;
        }
    }

    private void ChangeTextStartTFE()
    {
        if (safetyPinPulled && startSpraying && !fireExtinguisherThrown && this != null)
        {
            instructionText.text = "��ô�� ��ȭ��� �غ���� �ʿ���� ����� ������ Ư�� ��ȭ���Դϴ�. ��ô�� ��ȭ�⸦ ��� ���� ���� ����������";
            TFE.SetActive(true);
            //Instantiate(TFE, TFErespawnpos);
            Firerespawnpos.SetActive(true);
            playAudio();
            fireExtinguisherThrown = true;
        }
    }

    private void ChangeTextTFE()
    {
        if (safetyPinPulled && startSpraying && fireExtinguisherThrown && this != null)
        {
            instructionText.text = "�� ��ȭ�� ��� ����� ���������� ������� ȿ���� ���̰� �����մϴ�. ������ ��ȭ�� ������ �տ��ִ� ����â���� �о�ñ� �ٶ��ϴ�";
            playAudio();
            canvas.SetActive(true);
            this.canvasGo.SetActive(true);
            this.StartCoroutine(CoFadeOut());
        }
    }

    private IEnumerator CoFadeOut()
    {
        Color color = this.dim.color;

        yield return new WaitForSeconds(25.0f);

        while (true)
        {
            color.a += 0.01f;
            this.dim.color = color;

            if (color.a >= 1)
            {
                break;
            }
            yield return null;
        }
        SceneManager.LoadScene("Exhibit Scene");
    }

    //private IEnumerator moveScene()
    //{
    //    yield return new WaitForSeconds(25.0f);
    //    SceneManager.LoadScene("Exhibit Scene");
    //}

}