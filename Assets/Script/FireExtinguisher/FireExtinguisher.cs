using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private Transform spraypos;
    public ParticleSystem spray;
    //public Slider gaugeSlider; // ������ UI
    private AudioSource audiosource;

    private PullOutPin pulloutpin;

    private XRGrabInteractable grabInteractable;

    public GameObject pin;
    public Transform pinpos;

    private float maxGauge = 100f; // �ִ� ������ ��
    private float gaugeConsumptionRate = 20f; // ������ ��� �ӵ�
    private float currentGauge; // ���� ������ ��
    private bool isFiring=false; // �л� ������ ����

    public float rayLength = 10f;

    void Start()
    {
        Instantiate(pin, pinpos);
        pulloutpin = transform.GetChild(1).GetChild(0).GetComponent<PullOutPin>();
        audiosource = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartSpray(pulloutpin.pinpullout));
        grabInteractable.deactivated.AddListener(x => StopSpray());
        currentGauge = maxGauge;
    }

    void Update()
    {
        if (!grabInteractable.isSelected)
            StopSpray();

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

    public void StartSpray(bool pullout)//��ȭ�� �л� ����
    {
        if (pullout)
        {
            spray.Play();
            audiosource.Play();
            isFiring = true;
        }
    }
    public void StopSpray()//��ȭ�� �л� ����
    {
        spray.Stop();
        audiosource.Stop();
        isFiring = false;
    }


    void Raycastcheck()//��ȭ�� �л� �� ray�� �� �ִ��� üũ�ؼ� �� ��ȭ
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
