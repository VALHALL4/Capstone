using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private Transform spraypos;
    public ParticleSystem spray;
    public Slider gaugeSlider; // 게이지 UI
    private AudioSource audiosource;

    private XRGrabInteractable grabInteractable;

    public float maxGauge = 100f; // 최대 게이지 양
    public float gaugeConsumptionRate = 20f; // 게이지 사용 속도
    private float currentGauge; // 현재 게이지 양
    private bool isFiring=false; // 분사 중인지 여부

    public float rayLength = 10f;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartSpray());
        grabInteractable.deactivated.AddListener(x => StopSpray());
        currentGauge = maxGauge;
    }

    void Update()
    {
        if (isFiring)
            Raycastcheck();
    
        
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
        audiosource.Play();
        isFiring = true;
    }
    public void StopSpray()
    {
        spray.Stop();
        audiosource.Stop();
        isFiring = false;
    }


    void Raycastcheck()
    {
        RaycastHit hit;
        if (Physics.Raycast(spraypos.position, spraypos.up, out hit, rayLength, LayerMask.GetMask("Fire")))
        {       
            //hit.transform.gameObject.SendMessage()    
            Destroy(hit.collider.gameObject);

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
