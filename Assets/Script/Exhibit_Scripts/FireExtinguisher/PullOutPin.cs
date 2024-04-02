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
    // Start is called before the first frame update
    void Start()
    {
        XRSocketInteractor = GetComponent<XRSocketInteractor>();
        XRSocketInteractor.selectExited.AddListener(x => pulloutpin());
    }

    // Update is called once per frame
    private void pulloutpin()
    {
        pullout = true;
    }
}
