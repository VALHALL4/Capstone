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
        grabInteractable.activated.AddListener(x => StartSpray());
        grabInteractable.deactivated.AddListener(x => StopSpray());
        currentGauge = maxGauge;
    }

    void Update()
    {
       
      
        
    }

    private void FixedUpdate()
    {
        if (isFiring)
        {
            //UpdateGauge();
        }
    }


    

    public void StartSpray()
    {      
       spray.Play();
       UpdateGauge();
    }
    public void StopSpray()
    {
        spray.Stop();
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
