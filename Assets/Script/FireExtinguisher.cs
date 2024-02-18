using UnityEngine.UI;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private Transform spraypos;
    public ParticleSystem spray;
    public Slider gaugeSlider; // 게이지 UI

    public float maxGauge = 100f; // 최대 게이지 양
    public float gaugeConsumptionRate = 20f; // 게이지 사용 속도
    private float currentGauge; // 현재 게이지 양
    private bool isFiring; // 분사 중인지 여부

    void Start()
    {
        currentGauge = maxGauge;
    }

    void Update()
    {
        // 마우스 왼쪽 버튼을 누르는 동안
        if (Input.GetMouseButton(0))
        {
            Spray();
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
        gaugeSlider.value = currentGauge / maxGauge;
    }
}
