using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private Transform spraypos;
    public ParticleSystem spray;
    
    private AudioSource audiosource;

    private PullOutPin pulloutpin;

    private XRGrabInteractable grabInteractable;

    public GameObject pin;
    public Transform pinpos;

    private bool isFiring=false; // �л� ������ ����
    private bool isSprayevent = false;
    private bool isfirstgrab = false;

    public float rayLength;

    public delegate void FireExtinguisherGrabbedEvent();
    public static event FireExtinguisherGrabbedEvent OnFireExtinguisherGrabbed;

    public delegate void StartSprayingEvent();
    public static event StartSprayingEvent OnStartSpraying;

    void Start()
    {
        Instantiate(pin, pinpos); // ������ ����
        pulloutpin = transform.GetChild(1).GetChild(0).GetComponent<PullOutPin>();
        audiosource = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartSpray(pulloutpin.pinpullout));
        grabInteractable.deactivated.AddListener(x => StopSpray());
        grabInteractable.selectEntered.AddListener(OnGrabStart);
        
    }

    void Update()
    {   
        if (!grabInteractable.isSelected)
            StopSpray();

        if (isFiring)
            Raycastcheck();
           
    }

   
    private void OnGrabStart(SelectEnterEventArgs args)
    {
        if (!isfirstgrab)
        {
            OnFireExtinguisherGrabbed?.Invoke();
            isfirstgrab = true;
        }
    }

    public void StartSpray(bool pullout)//��ȭ�� �л� ����
    {
        if (pullout)
        {   
            if(!isSprayevent)
                OnStartSpraying?.Invoke();
            spray.Play();
            audiosource.Play();
            isFiring = true;
            isSprayevent = true;
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
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(spraypos.position, spraypos.up * rayLength);
    }

}
