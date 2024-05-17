using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PullOutPin : MonoBehaviour
{
    private bool pullout = false;

    public bool pinpullout
    {
        get { return pullout; }
    }
    private XRSocketInteractor XRSocketInteractor;

    public delegate void SafetyPinPulledEvent();
    public static event SafetyPinPulledEvent OnSafetyPinPulled;
    // Start is called before the first frame update
    void Start()
    {
        XRSocketInteractor = GetComponent<XRSocketInteractor>();
        if(XRSocketInteractor != null)
            XRSocketInteractor.selectExited.AddListener(x => pulloutpin());
    }

    // Update is called once per frame
    private void pulloutpin()
    {
        if (XRSocketInteractor != null)
        {
            if (!pullout)
                OnSafetyPinPulled?.Invoke();

            pullout = true;
        }

    }
}
