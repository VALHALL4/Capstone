using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabPin : MonoBehaviour
{
    private bool pullout=false;
    public bool pinpullout
    {
        get { return pullout; }
    }
    private Rigidbody rb;
    private XRGrabInteractable grabInteractable;

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

    }
    

    // Update is called once per frame
    void Update()
    {
        if (grabInteractable.isSelected)
            PinDestroy();
    }

    private void PinDestroy()
    {
        pullout = true;
    }
}
