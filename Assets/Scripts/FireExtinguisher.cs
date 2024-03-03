using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private Transform spraypos;
    public ParticleSystem spray;
    public Slider gaugeSlider; // ������ UI

    private XRGrabInteractable grabInteractable;

    public float maxGauge = 100f; // �ִ� ������ ��
    public float gaugeConsumptionRate = 20f; // ������ ��� �ӵ�
    private float currentGauge; // ���� ������ ��
    private bool isFiring; // �л� ������ ����

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        currentGauge = maxGauge;
    }

    void Update()
    {
        // ���콺 ���� ��ư�� ������ ����
        if (grabInteractable.isSelected)
        {
            if (Input.GetMouseButton(0))
            {
                Spray();
            }
        }
        else
        {
            isFiring = false;
            if (spray.isPlaying)
            {
                spray.Stop();
            }
        }
    }

    private void FixedUpdate()
    {
        if (isFiring)
        {
            UpdateGauge();
        }
    }


    

    private void Spray()
    {
        if (!spray.isPlaying && currentGauge > 0)
        {
            isFiring = true;
            spray.Play();
        }
    }

    private void UpdateGauge()
    {
        currentGauge -= gaugeConsumptionRate * Time.fixedDeltaTime;
        if (currentGauge < 0)
        {
            currentGauge = 0;
            isFiring = false;
            if (spray.isPlaying)
            {
                spray.Stop();
            }
        }
        UpdateGaugeUI();
    }

    private void UpdateGaugeUI()
    {
        //gaugeSlider.value = currentGauge / maxGauge;
    }
}
