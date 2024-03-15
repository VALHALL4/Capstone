using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private Transform spraypos;
    public ParticleSystem spray;
    public Slider gaugeSlider; // 게이지 UI

    private XRGrabInteractable grabInteractable;

    public float maxGauge = 100f; // 최대 게이지 양
    public float gaugeConsumptionRate = 20f; // 게이지 사용 속도
    private float currentGauge; // 현재 게이지 양
    private bool isFiring; // 분사 중인지 여부

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
